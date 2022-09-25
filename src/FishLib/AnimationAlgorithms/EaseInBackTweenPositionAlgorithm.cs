namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// EaseInBack
	/// </summary>
	public class EaseInBackTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (pos) * pos * ((1.70158 + 1) * pos - 1.70158);
		}

		#endregion
	}
}