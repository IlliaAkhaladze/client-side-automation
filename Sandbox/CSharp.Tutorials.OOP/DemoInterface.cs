using System;

namespace CSharp.Tutorials.OOP
{
	public class SettingDto
	{
		public SettingDto() { }
	}

	public class FirstSettings //: SettingDto
	{

	}

	public class SecondSettings : SettingDto
	{

	}

	public interface DemoInterface
	{

	}

	public interface ITrain
	{
		public void Move();
	}

	public interface IFly
	{
		public void Move(SettingDto settingDto);
		public void Move();
	}

	public class Vehicle : ITrain, IFly
	{
		public void Move(SettingDto settingDto)
		{
			
		}

		void ITrain.Move()
		{
			throw new NotImplementedException();
		}

		void IFly.Move()
		{
			throw new NotImplementedException();
		}
	}
}
