using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace Prac {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // テキストボックスの初期化
            IniFile ini = new IniFile("./setting.ini");

            textCollectionID.Text = ini["page1", "CollectionID"];
            textAPIKey.Text = ini["page1", "APIKey"];

            textServerDirectory.Text = ini["page2", "ServerDirectory"];
            textBoxMap.Text = ini["page2", "Map"];
        }

        /// <summary>
        /// コレクションクラス
        /// </summary>
        public class Collection {
            public Response response { get; set; }
            public class Child {
                public string publishedfileid { get; set; }
                public int sortorder { get; set; }
                public int filetype { get; set; }
            }

            public class Collectiondetail {
                public string publishedfileid { get; set; }
                public int result { get; set; }
                public List<Child> children { get; set; }
            }

            public class Response {
                public int result { get; set; }
                public int resultcount { get; set; }
                public List<Collectiondetail> collectiondetails { get; set; }
            }
        }

        /// <summary>
        /// アドオンクラス
        /// </summary>
        public class Addon {
            public Response response { get; set; }
            public class Tag {
                public string tag { get; set; }
            }

            public class Publishedfiledetail {
                public string publishedfileid { get; set; }
                public int result { get; set; }
                public string creator { get; set; }
                public int creator_app_id { get; set; }
                public int consumer_app_id { get; set; }
                public string filename { get; set; }
                public int file_size { get; set; }
                public string file_url { get; set; }
                public string hcontent_file { get; set; }
                public string preview_url { get; set; }
                public string hcontent_preview { get; set; }
                public string title { get; set; }
                public string description { get; set; }
                public int time_created { get; set; }
                public int time_updated { get; set; }
                public int visibility { get; set; }
                public int banned { get; set; }
                public string ban_reason { get; set; }
                public int subscriptions { get; set; }
                public int favorited { get; set; }
                public int lifetime_subscriptions { get; set; }
                public int lifetime_favorited { get; set; }
                public int views { get; set; }
                public List<Tag> tags { get; set; }
            }

            public class Response {
                public int result { get; set; }
                public int resultcount { get; set; }
                public List<Publishedfiledetail> publishedfiledetails { get; set; }
            }

        }

        /// <summary>
        /// INIファイルを読み書きするクラス
        /// Code by https://anis774.net/codevault/inifile.html
        /// </summary>
        public class IniFile {
            [DllImport("kernel32.dll")]
            private static extern int GetPrivateProfileString(
                string lpApplicationName,
                string lpKeyName,
                string lpDefault,
                StringBuilder lpReturnedstring,
                int nSize,
                string lpFileName);

            [DllImport("kernel32.dll")]
            private static extern int WritePrivateProfileString(
                string lpApplicationName,
                string lpKeyName,
                string lpstring,
                string lpFileName);

            string filePath;

            /// <summary>
            /// ファイル名を指定して初期化します。
            /// ファイルが存在しない場合は初回書き込み時に作成されます。
            /// </summary>
            public IniFile(string filePath) {
                this.filePath = filePath;
            }

            /// <summary>
            /// sectionとkeyからiniファイルの設定値を取得、設定します。 
            /// </summary>
            /// <returns>指定したsectionとkeyの組合せが無い場合は""が返ります。</returns>
            public string this[string section, string key] {
                set {
                    WritePrivateProfileString(section, key, value, filePath);
                }
                get {
                    StringBuilder sb = new StringBuilder(256);
                    GetPrivateProfileString(section, key, string.Empty, sb, sb.Capacity, filePath);
                    return sb.ToString();
                }
            }

            /// <summary>
            /// sectionとkeyからiniファイルの設定値を取得します。
            /// 指定したsectionとkeyの組合せが無い場合はdefaultvalueで指定した値が返ります。
            /// </summary>
            /// <returns>
            /// 指定したsectionとkeyの組合せが無い場合はdefaultvalueで指定した値が返ります。
            /// </returns>
            public string GetValue(string section, string key, string defaultvalue) {
                StringBuilder sb = new StringBuilder(256);
                GetPrivateProfileString(section, key, defaultvalue, sb, sb.Capacity, filePath);
                return sb.ToString();
            }
        }

        public Collection data_col;
        public Addon data_addon;
        
        /// <summary>
        /// リストから選択されたアドオンの情報を表示
        /// </summary>            
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e) {
            int num = checkedListBox.SelectedIndex;

            // 選択アドオンの情報を表示
            // 画像
            pictureAddon.ImageLocation = data_addon.response.publishedfiledetails[num].preview_url;
            // タイトル
            labelTitle.Text = data_addon.response.publishedfiledetails[num].title;
            // ID
            labelAddonID.Text = data_addon.response.publishedfiledetails[num].publishedfileid;
            // 説明
            textBoxDescription.Text = data_addon.response.publishedfiledetails[num].description;
            // タグ
            string t = "";
            data_addon.response.publishedfiledetails[num].tags.ForEach(tags => {
                t += tags.tag + " ";
            });
            labelTags.Text = t;

        }

        /// <summary>
        /// 画像がクリックされたときにアドオンのページを開く
        /// </summary>
        private void pictureAddon_Click(object sender, EventArgs e) {
            if (checkedListBox.SelectedIndex != -1) {
                int num = checkedListBox.SelectedIndex;
                string id = data_addon.response.publishedfiledetails[num].publishedfileid;
                Process.Start("https://steamcommunity.com/sharedfiles/filedetails/?id=" + id);
            }
        }

        /// <summary>
        /// GetInfoボタンをクリックしたときの処理
        /// </summary>
        private void buttonNet_Click(object sender, EventArgs e) {
            getCollectionInfo();

        }

        /// <summary>
        /// <param name="uri">POST送信先</param>
        /// <param name="postData">送信するデータ</param>
        /// </summary>
        /// <returns>JSON形式の文字列</returns>
        private string sendPost(string uri, string postData) {

            //progressBar1.Visible = true;

            // 文字エンコードをUTF-8に設定
            Encoding enc = Encoding.GetEncoding("utf-8");

            // バイト型配列に変換
            byte[] postDataBytes = Encoding.ASCII.GetBytes(postData);

            // WebRequestの作成
            WebRequest req = WebRequest.Create(uri);

            // メソッドにPOSTを指定
            req.Method = "POST";

            // ContentTypeを"application/x-www-form-urlencoded"にする
            req.ContentType = "application/x-www-form-urlencoded";

            // POST送信するデータの長さを指定
            req.ContentLength = postDataBytes.Length;
            progressBar1.PerformStep();

            // データをPOST送信するためのStreamを取得
            Stream reqStream = req.GetRequestStream();
            progressBar1.PerformStep();

            // 送信するデータを書き込む
            reqStream.Write(postDataBytes, 0, postDataBytes.Length);
            reqStream.Close();

            string str = "";
            try {
                // サーバーからの応答を受信するためのWebResponseを取得
                WebResponse res = req.GetResponse();
                progressBar1.PerformStep();

                // 応答データを受信するためのStreamを取得
                Stream resStream = res.GetResponseStream();
                progressBar1.PerformStep();

                // 受信して表示
                StreamReader sr = new StreamReader(resStream, enc);
                progressBar1.PerformStep();

                // ストリームに読み込み
                str = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception e) {
                MessageBox.Show("サーバーがエラーを返しました\n" + e.Data.ToString());
            }

            return str;
        }

        /// <summary>
        /// SteamAPIから情報の取得
        /// </summary>
        private void getCollectionInfo() {

            // POST 送信する文字列を作成
            string postData =
                "key=" + textAPIKey.Text +
                "&collectioncount=1" +
                "&publishedfileids[0]=" + textCollectionID.Text;

            // POSTを送信する
            progressBar1.Visible = true;
            string json = 
                sendPost("https://api.steampowered.com/ISteamRemoteStorage/GetCollectionDetails/v1/", postData);
            // JSONをデシリアライズ
            data_col = deserializeJson<Collection>(json);

            // チェックボックスに読み取ったAddonを追加
            addCollectionToBox(data_col);

            progressBar1.Visible = false;
            progressBar1.Value = 0;

            if (buttonNet.Enabled) {
                buttonNet.Enabled = false;
            }
        }

        /// <summary>
        /// <param name="id">Collection.Childのリスト</param> 
        /// </summary>
        /// <returns>アドオンの情報</returns>
        private List<Addon.Publishedfiledetail> getAddonInfo(List<Collection.Child> id) {
            string postData = "";
            try {
                // POST 送信する文字列を作成
                postData =
                    "key=" + textAPIKey.Text +
                    "&itemcount=" + id.Count;
                for (int i = 0; i < id.Count; i++) {
                    postData += "&publishedfileids[" + i + "]=" + id[i].publishedfileid;
                }

                labelAmount.Text = id.Count + " Addon(s) Loaded";

                string json =
                    sendPost(@"https://api.steampowered.com/ISteamRemoteStorage/GetPublishedFileDetails/v1/", postData);

                // JSONをデシリアライズ
                data_addon = deserializeJson<Addon>(json);

                return data_addon.response.publishedfiledetails;
            }
            catch (Exception e) {
                postData = "";
                MessageBox.Show("コレクションが空か、コレクションIDが間違っています\n" + e.Data.ToString());
                return new List<Addon.Publishedfiledetail>();
            }
        }


        /// <summary>
        /// <param name="json">JSON形式の文字列</param>
        /// </summary>
        private T deserializeJson<T>(string json) {
            return JsonConvert.DeserializeObject<T>(json);
        }

        // チェックボックスに追加
        private void addCollectionToBox(Collection data) {
            List<Addon.Publishedfiledetail> temp = getAddonInfo(data.response.collectiondetails[0].children);

            for (int i = 0; i < temp.Count; i++) {
                checkedListBox.Items.Add((i + 1) + "," + temp[i].title, true);
            }
        }

        /// <summary>
        /// テキストボックスなどのクリア
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e) {
            //textCollectionID.Text = "";
            //textAPIKey.Text = "";
            checkedListBox.Items.Clear();
            if (!buttonNet.Enabled) {
                buttonNet.Enabled = true;
            }
        }

        /// <summary>
        /// ディレクトリ指定
        /// </summary>
        private void buttonExport_Click(object sender, EventArgs e) {

            saveFileDialogExport.FileName = @"workshop.lua";

            // サーバーのディレクトリが設定されている場合はそのパスを初期パスとする
            if (textServerDirectory.Text != null) {
                saveFileDialogExport.InitialDirectory = textServerDirectory.Text + "\\garrysmod\\lua\\autorun\\server";
            }

            // OKがクリックされたときの処理
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK) {
                Stream str = saveFileDialogExport.OpenFile();

                if (str != null) {
                    StreamWriter writer = new StreamWriter(str);
                    // resource.AddWorkshop("ID")の形式でファイルに書き込む
                    // コレクションが読み込まれていなければエラーダイアログを表示する
                    try {
                        if (saveFileDialogExport.FileName.EndsWith("workshop.lua")) {

                            for (int i = 0; i < data_col.response.collectiondetails[0].children.Count; i++) {
                                if (checkedListBox.GetItemChecked(i)) {
                                    writer.WriteLine("resource.AddWorkshop(\"" + data_col.response.collectiondetails[0].children[i].publishedfileid + "\")");
                                }
                            }

                        }
                        else {
                            for (int i = 0; i < checkedListBox.Items.Count; i++) {
                                writer.WriteLine(checkedListBox.Items[i] + "," + "https://steamcommunity.com/sharedfiles/filedetails/?id=" + data_addon.response.publishedfiledetails[i].publishedfileid);
                            }
                        }
                    }
                    catch (Exception) {
                        MessageBox.Show("コレクションが読み込まれていません");
                    }
                    // ストリームのクローズ
                    writer.Close();
                    str.Close();
                }
            }            
        }

       　
        /// <summary>
        /// サーバーのディレクトリを指定するダイアログを開く
        /// </summary>
        private void buttonServerDirectory_Click(object sender, EventArgs e) {
            if (dialogServerDirectory.ShowDialog() == DialogResult.OK) {
                textServerDirectory.Text = dialogServerDirectory.SelectedPath;           
            }
            
            if (!File.Exists(textServerDirectory.Text + "\\srcds.exe")) {
                labelExistExe.Visible = true;
                buttonRun.Enabled = false;
            }
            else {
                labelExistExe.Visible = false;

                if (File.Exists(textServerDirectory.Text + "\\start.bat")) {
                    buttonRun.Enabled = true;
                }
            }
        }


        /// <summary>
        /// サーバーの起動
        /// </summary>
        private void buttonRun_Click(object sender, EventArgs e) {
            Process p = new Process();

            // コマンドプロンプトに設定したbatファイルを渡す
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.WorkingDirectory = textServerDirectory.Text;
            p.StartInfo.Arguments = @"/c start.bat";
            p.Start();
        }

        /// <summary>
        /// 起動用batファイルの作成
        /// </summary>
        private void buttonGenerate_Click(object sender, EventArgs e) {

            // 文字コードをShift-JISに設定
            Encoding sjis = Encoding.GetEncoding("Shift-JIS");
            StreamWriter writer = new StreamWriter(textServerDirectory.Text + "\\start.bat", false, sjis);

            string map = "gm_Flattywood";
            // マップの決定
            if(textBoxMap.Text == null) {
                map = textBoxMap.Text;
            }

            // 書き込む
            writer.Write(

@"@echo off
cls
echo Protecting srcds from crashes...
echo If you want to close srcds and this script, close the srcds window and type Y depending on your language followed by Enter.
title srcds.com Watchdog
:srcds
echo (%time%) srcds started.
start /wait srcds.exe -console -game garrysmod +map " + map + " +maxplayers 6 -authkey " + textAPIKey.Text + @" +host_workshop_collection " + textCollectionID.Text + @"
echo (%time%) WARNING: srcds closed or crashed, restarting.
goto srcds");

            writer.Close();
        }

        /// <summary>
        /// 入力状態をsetting.iniに書き込む
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e) {
            IniFile ini = new IniFile(".//setting.ini");

            ini["page1", "CollectionID"] = textCollectionID.Text;
            ini["page1", "APIKey"] = textAPIKey.Text;

            ini["page2", "ServerDirectory"] = textServerDirectory.Text;
            ini["page2", "Map"] = textBoxMap.Text;

            MessageBox.Show("保存しました");
        }

    }
}
