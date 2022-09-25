using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseTo
	/// </summary>
	public class EaseToTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return Math.Pow(pos, 0.25);
		}

		#endregion
	}
}