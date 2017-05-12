using System;

namespace mcOMRON
{
	#region [enum] - PLC memory areas - FINS commands

	/// <summary>
	/// enums PLC memory areas
	/// </summary>
	public enum MemoryArea : byte
	{
		CIO_Status = 0x00,
		TR_Status = 0x00,
		CPU_Bus_Status = 0x00,
		Auxiliary_Status = 0x00,
		Timer_Status = 0x01,
		Transition_Status = 0x03,
		Step_Status = 0x04,
		Forced_Status = 0x05,
		CIO = 0x80,
		TR = 0x80,
		CPU_Bus = 0x80,
		Auxiliary = 0x80,
		Timer_PV = 0x81,
		DM = 0x82,
		Forced = 0x85,
		DM_Exp1 = 0x90,
		DM_Exp2 = 0x91,
		DM_Exp3 = 0x92,
		DM_Exp4 = 0x93,
		DM_Exp5 = 0x94,
		DM_Exp6 = 0x95,
		DM_Exp7 = 0x96,
		DM_Exp8 = 0x97,
		DM_Exp_Current = 0x98,
		Action_Status = 0x1B
	};



	/// <summary>
	/// FINS commands
	/// </summary>
	enum FinsCommands
	{
		MemoryAreaRead,
		MemoryAreaWrite,
		ControllerDataRead,
	};

	#endregion



	/// <summary>
	/// 
	/// Version:	1.0
	/// Author:		Joan Magnet
	/// Date:		02/2015
	/// 
	/// base interface for FINS command layer
	/// 
	/// </summary>
	public interface IFINSCommand
	{
		/// <summary>
		/// return the connection status of the transport layer
		/// </summary>
		bool Connected
		{
			get;
		}


		/// <summary>
		/// return last error detected
		/// </summary>
		string LastError
		{
			get;
		}


		/// <summary>
		/// current transport layer
		/// </summary>
		ITransport Transport
		{
			get;
		}


		/// <summary>
		/// response array of the last FINS command
		/// </summary>
		Byte[] Response
		{
			get;
		}


		/// <summary>
		/// opens a connection 
		/// </summary>
		/// <returns></returns>
		bool Connect();


		/// <summary>
		/// close connection
		/// </summary>
		void Close();
		

		// Implemented FINS commands
		//
		bool MemoryAreaRead(MemoryArea area, UInt16 address, UInt16 count);
		bool MemoryAreaWrite(MemoryArea area, UInt16 address, UInt16 count, ref Byte [] data);
		bool ConnectionDataRead(Byte area);


		/// <summary>
		/// return the last dialog between PC and PLC
		/// </summary>
		/// <param name="Caption"></param>
		/// <returns></returns>
		string LastDialog(string Caption);
	}
}
