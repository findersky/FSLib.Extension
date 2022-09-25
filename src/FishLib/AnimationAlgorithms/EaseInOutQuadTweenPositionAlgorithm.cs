using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInOutQuad �㷨
	/// </summary>
	public class EaseInOutQuadTweenPositionAlgorithm : TweenPositionAlgorithm
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
				return 0.5 * Math.Pow(pos, 2);
			return -0.5 * ((pos -= 2) * pos - 2);

		}

		#endregion
	}
}