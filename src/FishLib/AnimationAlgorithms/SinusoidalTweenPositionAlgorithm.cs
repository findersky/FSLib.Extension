using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Sinusoidal
	/// </summary>
	public class SinusoidalTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (-Math.Cos(pos * Math.PI) / 2) + 0.5;
		}

		#endregion
	}
}