using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Blink
	/// </summary>
	public class BlinkTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return Math.Round(pos * 5) % 2;
		}

		#endregion
	}
}