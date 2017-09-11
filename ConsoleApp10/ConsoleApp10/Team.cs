namespace ConsoleApp10
{
    public class Team
    {
        IWorker teamLeader;
        IWorker workers;
        House house;
        public Team()
        {
            workers = new Worker();
            teamLeader = new TeamLeader();
            house = new House();
        }
        public void BuildingHouse()
        {
            teamLeader.MakeWork(house);

            workers.MakeWork(house);

            teamLeader.MakeWork(house);
        }
    }
}