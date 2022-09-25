using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInCubic �㷨
	/// </summary>
	public class EaseInCubicTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return Math.Pow(pos, 3);
		}

		#endregion
	}
}