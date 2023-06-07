# Kohya_LoRA_GUI

![GUI Image](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/621d1c16-d77e-4520-9f58-c374ca0b5cc3)


https://github.com/kohya-ss/sd-scripts のLoRA学習用のパラメータをGUI上で設定してコマンドラインに渡すGUIです。

## 他の機能
* 学習パラメータのプリセットをxmlで保存/読込
* tensorboardの起動
* GUI終了時にパラメータを記憶し、起動時に反映
* 複数LoRAの一括学習
* Dimのリサイズ

## 注意事項
[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法でセットアップしている環境を前提としています。
補助スクリプトなどで構築した環境で動作するかは不明です。

このソフトウェアはMIT Licenseで提供しています。

動作の保証はしません。また、このソフトウェアを使用したことによる損害などについて開発者は一切の責任を負いません。自己責任でご利用ください。

Windowsのバージョンによっては「ターミナルを閉じる」を押しても即時に閉じず、コマンドの実行終了後に閉じるようです。


## インストール方法
2つあります。好きなほうをご利用ください。

### A.GUIの簡易インストーラーを使用する
v1.6以降でご利用いただけます。

0.あらかじめgitとPython3.10をインストールしておく。

1.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_gui-x.x.x.zipをDLする

2.zipを解凍し、中にあるexeファイルをダブルクリックしてGUIを起動する。

3.GUIの上部にある「簡易インストーラー」をクリックして表示されるウィンドウに書いてある説明を読んでから、インストールボタンを押す。

4.インストールが完了したら、GUIを閉じてGUIが入ったフォルダをsd-scripts直下に移動させる。

### B.手動インストール
簡易インストールがうまくいかないか違うバージョンのtorchを入れたい場合はこちら

1.[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法sd-scriptsの導入をする。

2.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_gui-x.x.x.zipをDLする

3.zipを解凍してできたフォルダをsd-scriptに移動させる

注意:ディレクトリの階層は次のようにします。

![Image000](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/1c5ee177-85ad-47bb-9881-95aa3f28ef3b)

## 起動方法
Kohya_lora_trainer.exeをダブルクリックする。ショートカット作ると便利かも?

## 推奨動作環境
Windows 11(10は不明)

.NET Framework 4.7.2
