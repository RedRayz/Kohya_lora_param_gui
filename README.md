# Kohya_LoRA_GUI

![GUI Image](https://github.com/RedRayz/Kohya_lora_param_gui/assets/71994877/621d1c16-d77e-4520-9f58-c374ca0b5cc3)


https://github.com/kohya-ss/sd-scripts のLoRA学習用のパラメータをGUI上で設定してコマンドラインに渡すGUIです。

## 他の機能
* 学習パラメータのプリセットをxmlで保存/読込
* position_ids破損確認とtensorboardの起動
* GUI終了時にパラメータを記憶し、起動時に反映
* 複数LoRAの一括学習

## 注意事項
[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法でセットアップしている環境を前提としています。
補助スクリプトなどで構築した環境で動作するかは不明です。


このソフトウェアはMIT Licenseで提供しています。

動作の保証はしません。また、このソフトウェアを使用したことによる損害などについて開発者は一切の責任を負いません。自己責任でご利用ください。


## インストール方法
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
