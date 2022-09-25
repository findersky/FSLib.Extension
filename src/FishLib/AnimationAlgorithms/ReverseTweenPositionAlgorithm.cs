namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// Reverse
	/// </summary>
	public class ReverseTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return 1 - pos;
		}

		#endregion
	}
}