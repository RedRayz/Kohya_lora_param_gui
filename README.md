# Kohya_LoRA_param_GUI

![GUI Image](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/621d1c16-d77e-4520-9f58-c374ca0b5cc3)


https://github.com/kohya-ss/sd-scripts のLoRA学習用のパラメータをGUI上で設定してコマンドラインに渡すWindows専用のGUIです。

gradioを使用するものと比べ以下のメリットがあります。
- python、gradioを使用しないためファイルサイズが小さく起動が早い
- Webブラウザを使用しないため軽量
- 比較的コンパクトなUI

## 他の機能
* 学習パラメータのプリセットをxmlで保存/読込
* tensorboardの起動
* GUI終了時に設定を記憶し、次回起動時に反映
* 複数LoRAの一括学習
* Dimのリサイズ
* sd-scriptsのインストール・更新

## 注意事項
簡易インストーラか手動で[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法でセットアップしている環境を前提としています。

NVIDIA製グラフィックボードを搭載したパソコンでの動作を想定しています。

高DPIモニターではGUIの表示がぼやけます。ご了承ください。(スケーリングの挙動がおかしいので高dpi対応はやめた)

このソフトウェアは「現状のまま」提供され、一切の保証はありません。また、このソフトウェアを使用したことによる損害などについて開発者は一切の責任を負いません。自己責任でご利用ください。

このGUIはコマンドを生成し、sd-scriptsに渡しているだけであり直接の関係はありません。sd-scripts開発者にGUIについて問い合わせる行為はご遠慮ください。


## インストール方法

2つあります。好きなほうをご利用ください。

### A.GUIの簡易インストーラーを使用する
v1.6以降でご利用いただけます。

0.あらかじめ[git](https://git-scm.com/downloads/win)と[Python 3.11.9](https://www.python.org/ftp/python/3.11.9/python-3.11.9-amd64.exe)をインストールしておく。これらはsd-scriptsが必要とするものです。

※この時点で理解できない・AUTOMATIC1111のインストールが難しい人は学習も難しいと思われます。

1.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_param_gui-x.x.x.zipをDLする

2.zipを解凍し、中にあるexeファイルをダブルクリックしてGUIを起動する。

このとき英語で.NET Runtimeのインストーラーをダウンロードするか聞かれたらはいを押してダウンロードしてインストールしてください。

3.GUIの上部にある「簡易インストーラー」をクリックして表示されるウィンドウに書いてある説明を読んでから、インストールボタンを押す。

### B.手動インストール
簡易インストールがうまくいかないか違うバージョンのtorchを入れたい場合はこちら

1.[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法sd-scriptsの導入をする。

2.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_gui-x.x.x.zipをDLする

3.zipを解凍してできたフォルダをsd-scriptsと同じ階層のフォルダに移動させる

注意:ディレクトリの階層は次のようにします。

※LECOの学習機能は削除されました。
![image00004](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/9e078566-217e-4a45-b65a-b49014c2d680)


## 起動方法
Kohya_lora_trainer.exeをダブルクリックする。ショートカット作ると便利かも?

## 動作環境
* Windows 10/11 21H2(x86-64)以降

なお、Armアーキテクチャ(Snapdragonなど)のCPUは非対応です。

* [.NET Desktop Runtime 9.0](https://dotnet.microsoft.com/ja-jp/download/dotnet/thank-you/runtime-desktop-9.0.3-windows-x64-installer)

* Python 3.11.9または3.12.9

それ以外のPythonではsd-scriptsが動作しない可能性があります。

* Git

* Turing以降のNVIDIA製GPU
Torch 2.8.0以降、Volta以前のNVIDIA製GPUは非対応になります。さらに、2025年10月以降はNVIDIAによるドライバ更新は脆弱性修正のみとなります。

## ガイドなど

* [LoRA作成チュートリアル](https://note.com/redrayz/n/n05e93566e562)
* [学習のヒントなど](./docs/tips.md)
* サンプルプリセット: https://mega.nz/folder/ILdnzaxT#gTGQmcPUgdxKlLpIl9x__g
