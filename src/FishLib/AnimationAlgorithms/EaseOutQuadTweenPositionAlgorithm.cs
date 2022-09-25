using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutQuad
	/// </summary>
	public class EaseOutQuadTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return -(Math.Pow((pos - 1), 2) - 1);
		}

		#endregion
	}
}