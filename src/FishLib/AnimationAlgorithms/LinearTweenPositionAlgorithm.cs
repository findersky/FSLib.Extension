namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// �����㷨
	/// </summary>
	public class LinearTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return pos;
		}

		#endregion
	}
}