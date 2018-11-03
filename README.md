# SusLoader

Sus Loader は、 Seaurchin Score File を読み書きできる C# 向けのライブラリです。

## 使用例

カレントディレクトリに `Sample.sus` という名前のファイルがあるとします。

```cs
using System.IO;
using SusLoader;

class Program
{
	static void Main()
	{
		// スコアを読み込む
		var score = Score.Parse(File.ReadAllText("Sample.sus"));

		// 曲名を書き換える
		score.Title = "Hacked!";
		// 難易度をいじる
		score.Difficulty = DifficultyType.WorldsEnd;
		// World's END に
		score.WEType = "改";

		// 書き換えたものを保存する
		File.WriteAllText("SampleWE.sus", score.ToString());
	}
}
```

## ライセンス

[MIT](LICENSE)