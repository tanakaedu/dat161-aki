# デジタルアーツ東京　2016年度1年生用リポジトリ

# 便利リンク
- [ドットインストール HTML入門](http://dotinstall.com/lessons/basic_html_v3)
- [ドットインストール CSS入門](http://dotinstall.com/lessons/basic_css_v3)
- [ドットインストール Bootstrap 3.0入門](http://dotinstall.com/lessons/basic_twitter_bootstrap_v4)
- [HTMLテンプレート](http://coliss.com/articles/build-websites/operation/work/free-html-templates-for-responsive-2016-autumn.html)
- [ワイヤーフレーム例](http://coliss.com/articles/build-websites/operation/work/wireframes-and-prototypes-for-web-design.html)
- [Mayaのチュートリアルビデオ](http://area.autodesk.jp/movie/maya-learning-channel/)
- [ゲームに使えるフォント](http://alphawiki.net/vipgamecreator/index.php?%E3%82%B2%E3%83%BC%E3%83%A0%E3%81%AB%E4%BD%BF%E3%81%88%E3%82%8B%E3%83%95%E3%82%A9%E3%83%B3%E3%83%88)

# 10回目
- 正月休みの課題の確認
  - 学園祭の作品のリソースリスト
  - paiza learningのランク
  - 正月ミニ作品+リソースリスト

# 今後の予定(1コマは開発。もう1コマは講義)
1. みんなで開発
  - 体験入学用プログラムの改造
  - 対応ネットワークミニゲーム
1. UnityでAndroid用のビルド
1. クラス
1. オブジェクト指向設計
1. キャラクターのさまざまな移動方法
1. UI
1. パーティクル
1. 物理シェーダーによるエフェクト
1. シェーダースクリプト
1. Adobe XDによるワイヤーフレームの作成

## 小ネタ(時間があれば)
1. Unityちゃんの操作を改良(CharacterController)
1. [Unity公式チュートリアル Space Shooterの作成手順](https://github.com/tanakaedu/SpaceShooterTutorial/wiki)
1. 「ユニティちゃん2Dデータ」で、2Dグラフィックについて学ぶ
1. 「ユニティちゃん2Dデータ」のデモを改造する
1. 3Dデータの作り方

--------

# 9回目
- [ねとらぼ なぜアニメの放送は“落ちる”のか　放送が落ちる理由や待遇問題について現役アニメーター・制作進行に聞いた](http://nlab.itmedia.co.jp/nl/articles/1611/14/news066.html)
- スマートフォンの操作を実装する(マウスクリックで操作できるようにすればよい)
  - 仮想ゲームパッド
    - http://qiita.com/cabbage/items/7836efaa04bbb037b086
    - EventSystemが登録済みの場合は、新規の追加は不要
    - 2dでは、左右反転に変なことをやっている(localScaleでひっくり返している)。これが原因で操作をすると縮むので、Flip.Xで反転させるようにする
      - FixedUpdate()内の以下のコードを
```
            if (x != 0)
            {
                rigidbody2D.velocity = new Vector2(x * speed, rigidbody2D.velocity.y);
                Vector2 temp = transform.localScale;
                temp.x = x;
                transform.localScale = temp;
                anim.SetBool("dash", true);
            }
```

以下のように修正。

```
            if (x != 0)
            {
                rigidbody2D.velocity = new Vector2(x * speed, rigidbody2D.velocity.y);
                anim.SetBool("dash", true);
				SpriteRenderer sp = GetComponent<SpriteRenderer> ();
				sp.flipX = (x < 0);
            }
```
- 実機テスト
  - Androidの設定が完了しているPCと、していないPCがある。ローカルディスクCに[C:\Android\Sdk]フォルダーがあるPCがセットアップ済みのものなので、そのPCにAndroid端末を接続して、作業する
  - [これを右クリックして新しいタブで開く](http://am1tanaka.hatenablog.com/entry/2016/04/05/230542#Unity%E3%81%A8Android-SDK%E3%81%AE%E8%A8%AD%E5%AE%9A)
  - テスト用のAndroid端末のUnity Playerを起動して、USBで接続
  - Unityを起動
  - リビルドする
- Android用ビルド
  - [Unity Cloud Buildの利用](https://github.com/tanakaedu/dat161-aki/wiki/Unity-Cloud-Build%E3%81%A7Android%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%82%92%E3%83%93%E3%83%AB%E3%83%89)
    - これなら、PCへのAndroid環境のインストール不要
    - ただし、無料ライセンスだと1時間に1回しかビルドできない。有料版でも30分に1回とかなので、頻繁にビルドすることは想定されていない。通常のテストはUnity Editor上で行い、ある程度まとまったところで実機ビルドをする
- クリックした場所へ移動
- HPに参照URLやライセンス情報を表示
  - AtomでマークダウンをHTML化(Markdown Previewer上で右クリックして、[Save as HTML]で保存する

# 正月休みの課題
1. paiza learningのスキルチェックでランクをできるだけ上げる
1. 学園祭の作品のリソースリストを完成させる
1. ミニゲームを一つ完成させる
  - ゲームオーバーの条件のみを決めて、それ以外はできる限りシンプルにする
  - シーンは、「タイトルとゲームオーバーを兼用するもの」「ゲームシーン」の2つでよい
  - 利用した素材について、リソースリストのエクセルシートにまとめる
  - [Unity Asset Store](https://www.assetstore.unity3d.com/jp/)など、積極的に利用する
  - JOKER SCRIPTでもよい

# 8回目
- 話題
  - [paiza開発日誌 あなたは自分がエンジニアに向いていると思いますか？適性を知らないままの就職が招く不幸とは](http://paiza.hatenablog.com/entry/2016/11/29/%E3%81%82%E3%81%AA%E3%81%9F%E3%81%AF%E8%87%AA%E5%88%86%E3%81%8C%E3%82%A8%E3%83%B3%E3%82%B8%E3%83%8B%E3%82%A2%E3%81%AB%E5%90%91%E3%81%84%E3%81%A6%E3%81%84%E3%82%8B%E3%81%A8%E6%80%9D%E3%81%84%E3%81%BE)
- ドットインストール マークダウンのチェック
- リソースリストのチェック
- paiza learning に登録して実行(メールで登録して、GitHubアカウントと結びつけるとよい)

# 7回目
## 紹介
- [ブログ作成フレームワーク hexo](https://hexo.io/)
  - マークダウンなどで簡単にブログページを作成して、HTMLを生成してくれるフレームワーク
  - GitHub Pagesにアップすればブログが簡単に作れる
  - nodeなどが必要なので、現在学校では使えない

## 講義
- 作品に利用したリソースをエクセルにまとめる
- ドットインストールでの独習-GitHubに作ったものを公開していく

## その他作業
- 時間が余ったら、UnityのAndroidビルド
  - [Unity5.3.4でAndroidアプリのビルド](http://am1tanaka.hatenablog.com/entry/2016/04/06/002345)

# 6回目
## ネタ
- [モグラゲームス デジゲー博で見つけたおすすめ同人・インディゲーム12選](http://www.moguragames.com/entry/digigame-expo-report/)
- [競技プログラミング](http://programming-study.com/trouble/problem/)
- [Mayaのチュートリアルビデオ](http://area.autodesk.jp/movie/maya-learning-channel/)

## 講義-Webページ作成
- GitHub Pages, Atomエディター, HTML
  - [ドットインストール HTML入門](http://dotinstall.com/lessons/basic_html_v3)
  - [ドットインストール CSS入門](http://dotinstall.com/lessons/basic_css_v3)
- CSS, Bootstrap
  - [ドットインストール Bootstrap 3.0入門](http://dotinstall.com/lessons/basic_twitter_bootstrap_v4)
  - [HTMLテンプレート](http://coliss.com/articles/build-websites/operation/work/free-html-templates-for-responsive-2016-autumn.html)
  - [ワイヤーフレーム例](http://coliss.com/articles/build-websites/operation/work/wireframes-and-prototypes-for-web-design.html)

# 5回目
1. Google翻訳の紹介
1. [作品をGitHub Pagesで公開](http://am1tanaka.hatenablog.com/entry/2015/11/27/115926)
  - GitHub Pages, Atomエディター, HTML, CSS, Bootstrap

## 記事
- [転職エージェントは、本当にスゴ腕なのか！？──偽エンジニアを見抜けるか試してみた](https://codeiq.jp/magazine/2016/10/45639/)
- [AIについて](http://bylines.news.yahoo.co.jp/yuasamakoto/20161114-00064079/)


# 4回目
## 迷路のUnityちゃんのカメラについて
作業していたPCの kadai-temp フォルダーに調整済みのものを置いておきました。

修正手順を[こちら](https://github.com/tanakaedu/dat161-aki/wiki/%E3%82%AB%E3%83%A1%E3%83%A9%E3%81%AE%E8%AA%BF%E6%95%B4)にまとめました。

簡単なので、kadai-tempを使わず、現在作業しているものを修正した方がよさそうです。

## 仕上げ方針
### 迷路
- クリア
- 壁に埋まらないカメラ

###　ブロック崩し
- ボール速度上限
- ゲームオーバー
- クリア(別のレベルへの移動。とりあえずタイトル。次のステージができたら次のステージへ、進めて、最終面が終わったらクリア画面とか、タイトルへ)

### ピンボール
- フリッパーを動かす
- タイトル
- ゲームオーバー
- 得点

### ゴールを目指す
- タイトルシーンの作成
- ゲームオーバー状態の作成
- 次のステージへ進む状態の作成
- クリア状態の作成
- ゴールについたら次のステージのスタート地点か、クリア表示へ



# 3回目
- [ショットの作成](https://github.com/tanakaedu/dat161-aki/wiki/%E5%BC%BE%E3%82%92%E6%92%83%E3%81%A4)
- [弾があたった場所にパーティクルを表示](https://github.com/tanakaedu/dat161-aki/wiki/%E3%81%B6%E3%81%A4%E3%81%8B%E3%81%A3%E3%81%9F%E5%A0%B4%E6%89%80%E3%81%AB%E7%85%99%E3%82%92%E8%A1%A8%E7%A4%BA)
  - [スクリプトでゲームオブジェクトをに階層する](https://github.com/tanakaedu/dat161-aki/wiki/%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88%E3%81%A7%E8%A6%AA%E5%AD%90%E9%9A%8E%E5%B1%A4%E3%82%92%E8%A8%AD%E5%AE%9A%E3%81%99%E3%82%8B)
  - transform.parentに、親オブジェクトのtransformを代入
  - 座標はtransform.localPositionを利用
- グラフィックの透過
  - Photoshopなどで、透過度を設定して、psd形式か、png形式で保存して、Unityに読み込む
  - Quadなどに読み込んだ画像をドラッグ&ドロップして張り付ける
  - 貼り付けたゲームオブジェクトを選択
  - [Inspector]ビューから、テクスチャの[Shader]の左のを三角をクリックして開く
  - [Rendering Mode]の[Opaque]を[Transparent]に切り替え
  - 以上で画像の透過設定が反映される
- フォグ


# 2回目
- [パーティクル](https://github.com/tanakaedu/dat161-aki/wiki/%E3%83%91%E3%83%BC%E3%83%86%E3%82%A3%E3%82%AF%E3%83%AB)
- [ジャンプ](https://github.com/tanakaedu/dat161-aki/wiki/%E3%82%AD%E3%83%A3%E3%83%A9%E3%82%AF%E3%82%BF%E3%83%BC%E3%81%AE%E3%82%B8%E3%83%A3%E3%83%B3%E3%83%97)


# サイト紹介
- Unityインターハイ2016 https://inter-high.unity3d.jp/
- 面白そうなハード Arduboy http://ssci.to/2880

#　書籍紹介
まだ実際の本に目を通していないが、よさそうなので紹介。
- 北村 愛実 [Unity5の教科書 2D&3Dスマートフォンゲーム入門講座 (Entertainment&IDEA) ](https://www.amazon.co.jp/dp/4862463541/)
  - C#の入門からあるので復習向け。基本的な箇所からひっかかっていたらおススメ。
- Ben Tristem (著), Mike Geig (著) [24時間で学ぶ! Unity 5 基本操作と開発のコツ](https://www.amazon.co.jp/dp/4862463541/)
  - Unityの機能全体を紹介しながらゲームの開発までを凝縮。これからいよいよゲームを開発しようという人におススメ。数学や物理など、基本的な知識は本書では網羅できていないようなので、この本に書かれていることを全て理解できるようにするというのが、今後の目標の一つと言えるかもしれない。


# 後期1回目
- オプションつくり
- 効果音→ https://github.com/tanakaedu/dat161-aki/wiki/Unity:%E5%8A%B9%E6%9E%9C%E9%9F%B3

---


# 今後のテーマ
1. 夏休みの課題から
  - [x] ショットを打つ方向
    - 9/2に作成したスクリプト https://raw.githubusercontent.com/tanakaedu/dat161-aki/master/move.cs
  - [x] プレイヤーのキー操作(Rigidbody)
  - [x] ノベルゲームエンジン(JOKER SCRIPT)の利用
  - [x] SEとBGM https://github.com/tanakaedu/dat161-aki/wiki/Unity:%E5%8A%B9%E6%9E%9C%E9%9F%B3
  - [x] 重力加速度での操作
  - [x] 3D Textでの文字表示
  - [x] 迷路のアセットの当たり判定
  - [x] 爆発＝パーティクル
  - Unityちゃんの操作(CharacterController)
  - 当たり判定の変更方法
    - しゃがんだ時に、判定の大きさを変える
    - 配列で当たり判定
    - 当たるかどうか＝レイヤーで対応
  - 世界の果ての表現
1. [x] Visual C#の復習
2. [x] オプション作り
4. 「ユニティちゃん2Dデータ」で、2Dグラフィックについて学ぶ
5. 「ユニティちゃん2Dデータ」のデモを改造する
6. クラス、オブジェクト指向
8. 3Dデータの作り方
10. ネットワーク体験
11. 体験入学用プログラムの改造


---


# 15回目(9/16)
## 1コマ目 JOKER SCRIPT
- チュートリアル

### 紹介Webサイト
- イラストオーダーオーダーサービスサービスSKIMA https://skima.jp/
- IGDAジャパン ゲーム開発者推薦図書リスト(CEDEC2016)版 http://www.igda.jp/?p=4618

## 2コメ目
- 試験(30分)
- 休み中課題:オプション作りヒント


# 前期の復習
- Visual C#の復習

## 課題「オプション(或いは分身)を作ってみよう」
- マウスを動かすと、複数のラベルがマウスを追いかけるプログラムを作成する

1. 新しくプロジェクトを作成(プロジェクト名：option)
2. タイマーを設定(Interval は少し速めの方がきれいに動く。20程度)
3. 必要な変数を定義
3. コンストラクタ内に、ラベルを４つ程度作成して表示(数を自由に調整できるようにするとよい)
4. タイマー処理内で、マウスの座標を取得
5. 取得したマウスの座標を配列に入れる
6. ラベルに座標を設定する

### 締切：後期の開始を予定
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


---


# 14回目(9/9)
## 前回のサンプル
- ショットを打つ方向
  - 9/2に作成したスクリプト https://raw.githubusercontent.com/tanakaedu/dat161-aki/master/move.cs

## やる内容
- 前回のプログラムを改造
  - 辿り着いたら、fromに戻って、toにむけてうごく
  - toをキーで動かす
  - リアルタイムにSphereの方向を更新する


---


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


