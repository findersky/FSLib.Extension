namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// SwingFrom
	/// </summary>
	public class SwingFromTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			var s = 1.70158;
			return pos * pos * ((s + 1) * pos - s);

		}

		#endregion
	}
}