# Garrys-Mod-Addon-Lister
**Steamワークショップのコレクション情報から、アドオンの表示・適用ができる便利ツール**  
![Imgur](https://i.imgur.com/pVPl4Hh.png)  

# 概要
* SteamワークショップのコレクションIDを指定するだけで、適用するアドオンを一括管理  
* サーバー起動用バッチファイル、アドオン設定ファイル(workshop.lua)の生成もワンクリックで可能

# 使用ライブラリ
* [Newtonsoft Json.NET](https://github.com/JamesNK/Newtonsoft.Json)

# 必要なもの
* GarrysModServer  
* [SteamAPIキー](https://steamcommunity.com/dev/apikey)  
* (サーバーに導入予定の)コレクションのID  
  * ttps://steamcommunity.com/sharedfiles/filedetails/?id=xxxxxxxxxxにおける  
  xxxxxxxxxxの部分

# 各ボタンの説明
* Page1  
  ![Imgur](https://i.imgur.com/0C7DVvf.png)
  
  サーバーに導入したいコレクションのID、SteamAPIキーを入力し「GetInfo」をクリックすることで  
  コレクションに含まれているアドオンのリストが左に表示されます。
  
* Page2    
  ![imgur](https://imgur.com/etmsKZ6.png)
  * サーバーディレクトリ  
    GarrysModServerのディレクトリを指定します。
      
      
  * luaファイルを出力  
    アドオン設定ファイル(workshop.lua)を保存します。  
    左でチェックを入れたアドオンのみ適用されます。  
    (通常、サーバーディレクトリ/garrysmod/lua/autorun/serverに保存します)  
      
      
  * Map  
    サーバーで使用するマップを入力します。  
    空欄の場合は平坦マップ(gm_Flattywood)が選択されます。  
      
      
  * batファイルを生成  
    上で指定したサーバーディレクトリに、サーバー起動用バッチファイル(start.bat)を生成します。  
      
  * start.batを起動  
    上で生成されたstart.batを起動します。  
      
  * 入力状態を保存  
    このツールで入力された情報を保持します。  
    setting.iniに保存されます。  
