# デジタルアーツ東京　2016年度1年生用リポジトリ

# 13回目(9/2)
## 夏休みの宿題発表
- 指定のフォルダーに発表用データをコピー
- 持ち時間は一人10分

## 宿題内容
- ミニゲームを１本完成させる
  - 公開可能であること
    - 全てのリソースが著作権的に問題がないこと
    - 公序良俗に反しない
    - 過度なエロ禁止
    - 基準は、就職活動の時に使えるもの
  - Unityの場合、AssetStoreを活用するとよい
  - 著作権に問題がなければ、シナリオライターやその他プロジェクトを活用してもよい
    - [ひよこのたまご](http://hiyotama.hatenablog.com/)
      - Unityの適度なサイズのチュートリアルがある。これをベースにしてもよい
    - [Jokerスクリプト](http://jokerscript.jp/)
      - Unityで動くフリーのシナリオエンジン
    - [Unity公式のチュートリアル](http://unity3d.com/jp/learn/tutorials)
      - こちらにも多数のサンプルあり
  - プログラミングが厳しい人はこれを調べる > [プログラミングの必要なし！簡単にスマホアプリが開発できるツール9選](https://freelance.levtech.jp/guide/detail/38/?utm_content=bufferf4992&utm_medium=social&utm_source=twitter.com&utm_campaign=buffer)

---

# 今後のテーマ
1. Visual C#の復習
2. オプション作り
3. Unityの復習
4. 「ユニティちゃん2Dデータ」で、2Dグラフィックについて学ぶ
5. 「ユニティちゃん2Dデータ」のデモを改造する
6. クラス、オブジェクト指向
7. シナリオライター(JOKER SCRIPT)の利用
8. 3Dデータの作り方
9. ユニティちゃんのプログラムの改良
10. ネットワーク体験
11. 体験入学用プログラムの改造


# 前期の復習
- Visual C#の復習

## 課題「オプション(或いは分身)を作ってみよう」
- マウスを動かすと、複数のラベルがマウスを追いかけるプログラムを作成する

1. 新しくプロジェクトを作成(プロジェクト名：option)
2. タイマーを設定
3. 必要な変数を定義
3. コンストラクタ内に、ラベルを４つ程度作成して表示(数を自由に調整できるようにするとよい)
4. タイマー処理内で、マウスの座標を取得
5. 取得したマウスの座標を配列に入れる
6. ラベルに座標を設定する

### 締切
- 提出方法は、ネットドライブ上に提出用フォルダーを作成しておくので、そこにプロジェクトをまるごとコピーする

### 考え方
マウスのX座標を入れる配列msx[]を用意したとすると、以下のようなことを考えてみよう。

- msx[0]に、現在のマウスX座標
- msx[1]に、前回のマウスX座標
- msx[2]に、前々回のマウスX座標
- msx[3]に、さらにその前のマウスX座標
- ：
以上のように、配列にマウスのX座標が記録されていくとしよう。msx[0]の座標にラベルを表示したら、X方向が現在のマウスの場所に一致します。もう一つのラベルをmsx[1]の位置に表示すれば、1フレーム前のマウスの座標にラベルが表示されます。msx[2]の位置にまた別のラベルを表示すれば、2フレーム前にマウスがあった場所にラベルが表示されます。これを繰り返したら、複数のラベルが、マウスが通った軌跡をなぞっていくようになります。

上記の例では、1フレームずつ前の場所を参照するので、ラベルはくっついて表示されます。これを10フレーム前にしたらどうなるでしょうか。タイマーを初期設定のまま使っていた場合は、1秒に10フレーム処理しますので、1秒前にマウスがあった場所にラベルが表示されるようになり、より面白い動きになります。

配列は無限に作ることはできません。上記の処理をずっと繰り返すには工夫が必要です。工夫の仕方を考えてみましょう。

