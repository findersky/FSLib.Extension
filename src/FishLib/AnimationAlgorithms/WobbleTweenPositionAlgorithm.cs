using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Wobble
	/// </summary>
	public class WobbleTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (-Math.Cos(pos * Math.PI * (9 * pos)) / 2) + 0.5;
		}

		#endregion
	}
}