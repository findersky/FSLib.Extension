namespace FSLib.Extension.AnimationAlgorithms
{
	/// <summary>
	/// λ���㷨�ӿ�
	/// </summary>
	public interface ITweenPositionAlgorithm
	{
		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		double GetPosition(double pos);

		/// <summary>
		/// ������ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="initialPos">��ʼ��λ��</param>
		/// <param name="pos">��ǰλ��</param>
		/// <returns>Ӧ�ô��ڵ�λ��</returns>
		int GetPosition(int initialPos, double pos);

		/// <summary>
		/// ������ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="initialPos">��ʼ��λ��</param>
		/// <param name="pos">��ǰ���λ��</param>
		/// <param name="totalLength">λ�ñ仯�ܳ��ȵ�λ</param>
		/// <returns>Ӧ�ô��ڵ�λ��</returns>
		int GetPosition(int initialPos, double pos, double totalLength);
	}
}