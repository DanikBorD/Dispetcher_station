using System;

namespace mcOMRON
{
	/// <summary>
	/// Conversion between Bytes[], UInt16, UInt32
	/// </summary>
	public static class BTool
	{
		/// <summary>
		/// convert UInt16 into Byte[]
		/// </summary>
		/// <param name="value"></param>
		public static Byte[] Uint16toBytes(UInt16 value)
		{
			Byte[] resp = new Byte[2];

			resp[1] = (Byte)(value & 0xFF);
			resp[0] = (Byte)((value >> 8) & 0xFF);

			return resp;
		}


		/// <summary>
		/// convertsUInt32 into UInt16[]
		/// </summary>
		/// <param name="value"></param>
		public static UInt16[] Uint32toUInt16(UInt32 value)
		{
			UInt16[] resp = new UInt16[2];

			resp[1] = (UInt16)(value & 0xFFFF);
			resp[0] = (UInt16)((value >> 16) & 0xFFFF);

			return resp;
		}


		/// <summary>
		/// convert 2 Bytes into UInt16
		/// </summary>
		/// <param name="B1"></param>
		/// <param name="B2"></param>
		/// <returns></returns>
		public static UInt16 BytesToUInt16(Byte B1, Byte B2)
		{
			UInt16 value = B1;
			value <<= 8;
			value += Convert.ToUInt16(B2);
			return value;
		}
	}


	#region [DDM] manage 2 DM's like one single 32 bits value


	/// <summary>
	/// DDM
	/// 
	/// class to manage 2 DM's like one single 32 bits value
	/// </summary>
	public class DDM
	{
		/// <summary>
		/// unsigned int 32 bits value
		/// </summary>
		private UInt32 _value;


		/// <summary>
		/// return the converted 32 bits value
		/// </summary>
		public UInt32 Value
		{
			get { return _value; }
		}


		/// <summary>
		/// constructor
		/// </summary>
		public DDM()
		{
			_value = 0;
		}


		/// <summary>
		/// convert two UInt16 values into one UInt32 value
		/// </summary>
		/// <param name="word1"></param>
		/// <param name="word2"></param>
		public UInt32 Set(UInt16 word1, UInt16 word2)
		{
			this._value = (UInt32)(word1 + (word2 << 16));
			return this._value;
		}


		/// <summary>
		/// return a formatted string
		/// </summary>
		/// <param name="format"></param>
		/// <returns></returns>
		public string ToString(string format = "")
		{
			return this.Value.ToString(format);
		}
	}

	#endregion
}
