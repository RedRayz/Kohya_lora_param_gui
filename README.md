# Kohya_LoRA_GUI

<img width="1321" alt="image00" src="https://user-images.githubusercontent.com/71994877/222030715-e454e99a-1f2d-4818-b0d3-c9cb5998c72c.png">

https://github.com/kohya-ss/sd-scripts の学習用のパラメータ設定してコマンドラインに渡すGUIです。

## 他の機能
* 学習パラメータのプリセットをxmlで保存/読込
* position_ids破損確認とtensorboardの起動
* GUI終了時にパラメータを記憶し、起動時に反映

## 注意事項
[sd-scriptsのREADME](https://github.com/kohya-ss/sd-scripts/blob/main/README-ja.md)の方法でセットアップしている環境を前提としています。
補助スクリプトなどで構築した環境は動作対象外です。

動作の保証はしません。自己責任でご利用ください。


## インストール方法
1.[releases](https://github.com/RedRayz/Kohya_lora_param_gui/releases)からkohya_lora_gui-x.x.x.zipをDLする

2.zipを解凍してできたフォルダをsd-scriptに移動させる

注意:ディレクトリの階層は次のようにします。

![image1](https://user-images.githubusercontent.com/71994877/222900350-9585963f-5514-4313-82c9-e20f72f2f88c.png)

## 起動方法
Kohya_lora_trainer.exeをダブルクリックする。ショートカット作ると便利かも?

## 推奨動作環境
Windows 11(10は不明)

.NET Framework 4.7.2
