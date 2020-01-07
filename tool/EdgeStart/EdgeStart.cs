using System;
namespace EdgeStartSpace
{
  public static class EdgeStart
  {
    public static void Main(string[] args)
    {
      // 変数宣言
      string hikisu = "";
      // 正規表現(URLのパターン)
      System.Text.RegularExpressions.Regex urlReg = new System.Text.RegularExpressions.Regex(@"\As?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+\z");
      try
      {
        // 引数が存在する場合かつ第一引数がURLの場合
        if (args.Length > 0 && urlReg.IsMatch(args[0]))
        {
            hikisu = args[0];
        }
        // Edge起動
        System.Diagnostics.Process.Start("microsoft-edge:"+hikisu);
      }
      catch (Exception ex)
      {
        // 例外処理
        Console.WriteLine(ex);
      }
      finally
      {
        // 終了処理
      }
    }
  }
}