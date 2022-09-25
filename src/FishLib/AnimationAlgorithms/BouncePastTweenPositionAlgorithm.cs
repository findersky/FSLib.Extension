namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// BouncePast
	/// </summary>
	public class BouncePastTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			if (pos < (1 / 2.75))
			{
				return (7.5625 * pos * pos);
			}
			if (pos < (2 / 2.75))
			{
				return 2 - (7.5625 * (pos -= (1.5 / 2.75)) * pos + .75);
			}
			if (pos < (2.5 / 2.75))
			{
				return 2 - (7.5625 * (pos -= (2.25 / 2.75)) * pos + .9375);
			}
			return 2 - (7.5625 * (pos -= (2.625 / 2.75)) * pos + .984375);
		}

		#endregion
	}
}