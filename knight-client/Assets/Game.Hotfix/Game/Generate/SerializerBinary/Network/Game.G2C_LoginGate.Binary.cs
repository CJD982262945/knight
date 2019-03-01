using System.IO;
using Knight.Hotfix.Core;
using Knight.Core;

/// <summary>
/// Auto generate code, not need modify.
/// </summary>
namespace Game
{
	public partial class G2C_LoginGate
	{
		public override void Serialize(BinaryWriter rWriter)
		{
			base.Serialize(rWriter);
			rWriter.Serialize(this.RpcId);
			rWriter.Serialize(this.Error);
			rWriter.Serialize(this.Message);
			rWriter.Serialize(this.PlayerId);
		}
		public override void Deserialize(BinaryReader rReader)
		{
			base.Deserialize(rReader);
			this.RpcId = rReader.Deserialize(this.RpcId);
			this.Error = rReader.Deserialize(this.Error);
			this.Message = rReader.Deserialize(this.Message);
			this.PlayerId = rReader.Deserialize(this.PlayerId);
		}
	}
}

