using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInOutCirc
	/// </summary>
	public class EaseInOutCircTweenPositionAlgorithm : TweenPositionAlgorithm
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
				return -0.5 * (Math.Sqrt(1 - pos * pos) - 1);
			return 0.5 * (Math.Sqrt(1 - (pos -= 2) * pos) + 1);

		}

		#endregion
	}
}