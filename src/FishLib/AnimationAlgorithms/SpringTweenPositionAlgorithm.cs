using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Spring
	/// </summary>
	public class SpringTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return 1 - (Math.Cos(pos * 4.5 * Math.PI) * Math.Exp(-pos * 6));
		}

		#endregion
	}
}