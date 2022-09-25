using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInSine
	/// </summary>
	public class EaseInSineTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return -Math.Cos(pos * (Math.PI / 2)) + 1;
		}

		#endregion
	}
}