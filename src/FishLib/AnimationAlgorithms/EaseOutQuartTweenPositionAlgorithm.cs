using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutQuart
	/// </summary>
	public class EaseOutQuartTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return -(Math.Pow((pos - 1), 4) - 1);
		}

		#endregion
	}
}