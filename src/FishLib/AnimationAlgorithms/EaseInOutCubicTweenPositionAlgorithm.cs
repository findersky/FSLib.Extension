using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInOutCubic
	/// </summary>
	public class EaseInOutCubicTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			if ((pos /= 0.5) < 1)
				return 0.5 * Math.Pow(pos, 3);
			return 0.5 * (Math.Pow((pos - 2), 3) + 2);
		}

		#endregion
	}
}