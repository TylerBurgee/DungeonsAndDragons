using System;

public class Die
{
	private int numOfSides;
	private int numOfDie;
	private Random random = new Random();

	public Die(int numOfSides, int numOfDie)
	{
		this.numOfSides = numOfSides;
		this.numOfDie = numOfDie;
    }

	public List<int> roll()
	{
		int die_result = 0;
		List<int> dice_list = new List<int>();

		for (int i = 0; i < this.numOfDie; i++)
		{
			die_result = random.Next(1, this.numOfSides);
            dice_list.Add(die_result);
        }
        return dice_list;
    }

	public int get_sum(List<int> dice_list)
	{
		int dice_total = 0;
		for (int i = 0; i < dice_list.Count; i++)
		{
			dice_total += dice_list[i];
		}
		return dice_total;
	}

	public string get_results(List<int> dice_list)
	{
		string die_results = "";

		for (int i = 0; i < dice_list.Count; i++)
		{
			if (i == dice_list.Count - 1)
			{
				die_results += dice_list[i];
            }
			else
			{
                die_results += dice_list[i] + "+";
            }
			
		}
		return die_results;
	}
}
