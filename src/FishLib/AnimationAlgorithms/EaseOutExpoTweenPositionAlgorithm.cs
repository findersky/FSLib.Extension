using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutExpo
	/// </summary>
	public class EaseOutExpoTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (pos == 1) ? 1 : -Math.Pow(2, -10 * pos) + 1;
		}

		#endregion
	}
}