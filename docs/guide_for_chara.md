# キャラ学習手順

作成中...
Constructing...

使用するツール類

- Grabber
  
  教師画像の収集に使用
- XnConvert
  
  一括で画像のリサイズ
- WD14Tagger
  
  1111のExtension。入力画像のDanbooruタグを推論する。キャプション作成に使用する。

## 1.学習用フォルダ作成
フォルダの階層:

親フォルダ

　┗train

　　┗繰り返し数_名前(例:8_sample)

繰り返し数は1epochが512steps前後になるよう調整する。

## 2.教師画像を集める

Grabberで適当なソースから画像を64枚以上収集する。

## 3.リサイズする

XnConvertを用いて変換する。png、色深度を24bit、リサイズで長辺を1536pxにする。出力先は"繰り返し数_名前"のフォルダ

## 4.WD14Taggerでタグ付け

Batch processで一括でやる。Modelはconvnext-v2を使用。

Additional Tagsはキャラ名を入れる。

Exclude Tagsは`blurry,blush,virtual_youtuber,キャラの身体的特徴`を入れる。

## 5.GUI側で設定して学習開始、完成

サンプルプリセットを読み込んでから、教師画像フォルダに1.で作成したtrainフォルダを指定する。出力先は好きな場所でも。

設定したら学習開始。
