using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseFrom
	/// </summary>
	public class EaseFromTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return Math.Pow(pos, 4);
		}

		#endregion
	}
}