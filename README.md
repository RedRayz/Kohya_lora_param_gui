# Kohya_LoRA_GUI

![GUI Image](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/621d1c16-d77e-4520-9f58-c374ca0b5cc3)


https://github.com/kohya-ss/sd-scripts のLoRA学習用のパラメータをGUI上で設定してコマンドラインに渡すWindows専用のGUIです。

gradioを使用するものと比べ以下のメリットがあります。
- python、gradioを使用しないため容量を圧迫せず起動が早い
- Webブラウザを使用しないため軽量
- 比較的コンパクトなUI

## 他の機能
* 学習パラメータのプリセットをxmlで保存/読込
* tensorboardの起動
* GUI終了時に設定を記憶し、次回起動時に反映
* 複数LoRAの一括学習
* Dimのリサイズ
* sd-scriptsのインストール・更新
* LECOの学習およびconfig,promptsの生成

## 注意事項
[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法でセットアップしている環境を前提としています。
補助スクリプトなどで構築した環境で動作するかは不明です。

NVIDIA製グラフィックボードを搭載したパソコンでの動作を想定しています。

高DPIモニターではGUIの表示がぼやけます。ご了承ください。(スケーリングの挙動がおかしいので高dpi対応はやめた)

このソフトウェアは「現状のまま」提供され、一切の保証はありません。また、このソフトウェアを使用したことによる損害などについて開発者は一切の責任を負いません。自己責任でご利用ください。


## インストール方法
2つあります。好きなほうをご利用ください。

### A.GUIの簡易インストーラーを使用する
v1.6以降でご利用いただけます。

0.あらかじめgitとPython3.10(3.11でもOK)をインストールしておく。

1.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_gui-x.x.x.zipをDLする

2.zipを解凍し、中にあるexeファイルをダブルクリックしてGUIを起動する。

3.GUIの上部にある「簡易インストーラー」をクリックして表示されるウィンドウに書いてある説明を読んでから、インストールボタンを押す。

### B.手動インストール
簡易インストールがうまくいかないか違うバージョンのtorchを入れたい場合はこちら

1.[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法sd-scriptsの導入をする。

2.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_gui-x.x.x.zipをDLする

3.zipを解凍してできたフォルダをsd-scriptsと同じ階層のフォルダに移動させる

注意:ディレクトリの階層は次のようにします。

LECOも同じようにします。

![image00004](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/9e078566-217e-4a45-b65a-b49014c2d680)


## 起動方法
Kohya_lora_trainer.exeをダブルクリックする。ショートカット作ると便利かも?

## 推奨動作環境
Windows 10/11 21H2以降

## ガイドなど

* [学習のヒントなど](./docs/tips.md)
* サンプルプリセット: https://mega.nz/folder/ILdnzaxT#gTGQmcPUgdxKlLpIl9x__g
