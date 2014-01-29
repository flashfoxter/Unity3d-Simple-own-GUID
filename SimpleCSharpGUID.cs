using System;
using UnityEngine;
using System.Collections;

public static class SimpleCSharpGUID
{
		public const string ALPHANUMERIC_CAPS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		public const string ALPHA_CAPS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		public const string NUMERIC = "1234567890";




		public static string GetRandomString(int length, params char[] chars)
		{

				string s = "";
				for (int i = 0; i < length; i++)
						s += chars[UnityEngine.Random.Range(0, chars.Length)];

				return s;

		}


		public static string Generate ()
		{
				//string id1  = UnityEditor.
				string id1 = (UnityEngine.Random.Range (0, Int32.MaxValue)).ToString(); // - 00000000
				string id2 = GetRandomString (4, ALPHANUMERIC_CAPS.ToCharArray()); // - 0000
				string id3 = GetRandomString (4, ALPHANUMERIC_CAPS.ToCharArray()); // - 0000
				string id4 = GetRandomString (4, ALPHANUMERIC_CAPS.ToCharArray()); // - 000
				string id5 = GetRandomString (12, ALPHANUMERIC_CAPS.ToCharArray()); //LAST BLOCK - 000000000000 
						

				string GUID =  id1 + "-" + id2 + "_" + id3 + "-" + id4 + "-" + id5;

				Debug.Log ("GUID: " + GUID);

				return GUID;



		}
}
