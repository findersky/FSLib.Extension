namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// SwingTo
	/// </summary>
	public class SwingToTweenPositionAlgorithm : TweenPositionAlgorithm
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
			return (pos -= 1) * pos * ((s + 1) * pos + s) + 1;
		}

		#endregion
	}
}