using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Pulse
	/// </summary>
	public class PulseTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (-Math.Cos((pos * (5 - .5) * 2) * Math.PI) / 2) + .5;
		}

		#endregion
	}
}