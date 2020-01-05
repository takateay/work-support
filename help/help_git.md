# Gitの使い方
## 初期設定
1. 現在の作業フォルダを確認する
    ```
    pwd
    ```
1. 現在のフォルダをGitでバージョン管理する
    ```
    git init
    ```
1. Git管理除外ファイルを作成する
    ```
    touch .gitignore
    ```
1. Vimを起動して、ファイルを開く
    ```
    vim .gitignore
    ```
1. 除外対象を入力する
    ```
    ファイル名/
    ```
1. コマンド入力モードに切り替え
    ```
    Escキー
    ```
1. ファイルを保存してVimを終了する
    ```
    :wq
    ```
1. Git管理の対象に、除外するもの以外全てを追加する([※1](#※１：改行コードを変換する旨、警告された場合))
    ```
    git add .
    ```
1. コミットする（追加を確定する）
    ```
    git commit -m "初めてのコミット"
    ```
---
## ※１：[改行コード](./help-common.md#改行コード)を変換する旨、警告された場合
- 警告メッセージ
    ```
    warning: CRLF will be replaced by LF in {ファイル名}.
    The file will have its original line endings in your working directory
    ```
- 対応方法
    - 変換は、想定通りのため警告を無視してOK

    - 変換をしないように設定したい場合は、以下のコマンドを実行
        ```
        git config --global core.autoCRLF false
        ```
# 基本
Gitの設定ファイルは3種類ある。
|種類|対象範囲|場所|備考|
|:--|:--|:--|:--|
|system|システム全体（全ユーザーの全リポジトリ）|/etc/gitconfig|-|
|global|該当ユーザーの全リポジトリ|~/.gitconfig|ホーム直下|
|local|該当リポジトリ|repository/.git/config|リポジトリの.git直下|
# コマンド一覧
|コマンド|オプション|説明|
|:--|:--|:--|
|config||Git設定|
|config|-l|Git設定の確認|
# コマンド一覧(用途別)
- リポジトリごとのGitの設定を確認する
    ```
    git config --local -l
    ```
- ユーザごとのGitの設定を確認する
    ```
    git config --global -l
    ```
- システム全体のGitの設定を確認する
    ```
    git config --system -l
    ```
- Git-GUIの文字コードをUTF-8に変更する（文字化け対策）
    ```
    git config --local gui.encoding utf-8
    ```