using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutCirc
	/// </summary>
	public class EaseOutCircTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return Math.Sqrt(1 - Math.Pow((pos - 1), 2));
		}

		#endregion
	}
}