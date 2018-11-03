using System;
using System.Collections.Generic;
using System.IO;

namespace SusLoader
{
	public class Score
	{
		/// <summary>
		/// この譜面の曲名を取得または設定します。
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// この譜面のアーティスト名を取得または設定します。
		/// </summary>
		public string Artist{ get; set; }
		/// <summary>
		/// ノーツデザイナー名を取得または設定します。
		/// </summary>
		public string Designer { get; set; }
		/// <summary>
		/// この譜面の難易度を取得または設定します。
		/// </summary>
		public DifficultyType Difficulty { get; set; }
		/// <summary>
		/// World's END の譜面を表す一文字を取得または設定します。
		/// </summary>
		public string WEType{ get; set; }

		/// <summary>
		/// 譜面定数を取得または設定します。
		/// </summary>
		public double ScoreConstant { get; set; }

		/// <summary>
		/// 譜面定数をプレイヤーレベルの文字列に変換します。
		/// </summary>
		public string LevelToString() => (int)ScoreConstant + (ScoreConstant % 1 >= 0.7 ? "+" : "");

		/// <summary>
		/// この譜面の楽曲IDを取得または設定します。
		/// </summary>
		public string SongId { get; set; }

		/// <summary>
		/// この譜面で使う楽曲のパスを取得または設定します。
		/// </summary>
		public string WavePath { get; set; }

		/// <summary>
		/// 楽曲の再生オフセットを取得または設定します。
		/// </summary>
		public double WaveOffset { get; set; }

		/// <summary>
		/// ジャケット画像のパスを取得または設定します。
		/// </summary>
		public string JacketPath { get; set; }

		/// <summary>
		/// 背景画像のパスを取得または設定します。
		/// </summary>
		public string BackgroundPath { get; set; }

		/// <summary>
		/// 背景に表示される動画のパスを取得または設定します。
		/// </summary>
		public string MoviePath { get; set; }

		/// <summary>
		/// 背景に表示される動画の再生オフセットを取得または設定します。
		/// </summary>
		public double MovieOffset { get; set; }

		/// <summary>
		/// この譜面のリクエストディレクティブを取得または設定します。
		/// </summary>
		public Dictionary<string, string> Requests { get;} = new Dictionary<string, string>();

		/// <summary>
		/// susフォーマットのテキストを文字列として読み込み、パースします。
		/// </summary>
		/// <param name="text">sus フォーマットの譜面テキスト。</param>
		/// <returns>解析された譜面を表す <see cref="Score"/> オブジェクト。</returns>
		public static Score Parse(string text)
		{
			throw new NotImplementedException("もうちょっと待ってくれ");
		}

	}
}
