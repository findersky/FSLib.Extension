using System;

namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Elastic
	/// </summary>
	public class ElasticTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return -1 * Math.Pow(4, -8 * pos) * Math.Sin((pos * 6 - 1) * (2 * Math.PI) / 2) + 1;
		}

		#endregion
	}
}