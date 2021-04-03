using Computers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Computers
{
    public sealed class DatabaseContext
    {
        private readonly FirestoreDb db;
        private readonly string path;

        private readonly CollectionReference motherboardsRef;
        private readonly CollectionReference processorsRef;
        private readonly CollectionReference manufacturersRef;
        private readonly CollectionReference diskDrivesRef;
        private readonly CollectionReference employeesRef;
        private readonly CollectionReference powerSuppliesRef;
        private readonly CollectionReference memoriesRef;
        private readonly CollectionReference hardDrivesRef;
        private readonly CollectionReference graphicCardsRef;
        private readonly CollectionReference computersRef;
        private readonly CollectionReference statusesRef;
        private readonly CollectionReference errorsRef;

        private DatabaseContext()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "firebase-key.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("computersapp-b46af");

            motherboardsRef = db.Collection("motherboards");
            processorsRef = db.Collection("processors");
            manufacturersRef = db.Collection("manufacturers");
            diskDrivesRef = db.Collection("disk-drives");
            employeesRef = db.Collection("employees");
            powerSuppliesRef = db.Collection("power-supplies");
            memoriesRef = db.Collection("memories");
            hardDrivesRef = db.Collection("hard-drives");
            graphicCardsRef = db.Collection("graphic-cards");
            computersRef = db.Collection("computers");
            statusesRef = db.Collection("statuses");
            errorsRef = db.Collection("errors");
        }
        private static DatabaseContext instance;
        public static DatabaseContext Shared
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseContext();
                }
                return instance;
            }
        }
        public async Task<string> AddEmployee(Employee employee)
        {
            var id = employeesRef.Document().Id;
            await employeesRef.Document(id).SetAsync(employee.ToDict());
            return id;
        }
        public async Task<string> AddStatus(Status status)
        {
            var id = statusesRef.Document().Id;
            await statusesRef.Document(id).SetAsync(status.ToDict());
            return id;
        }
        public async Task<string> AddManufacturer(Manufacturer manufacturer)
        {
            var id = manufacturersRef.Document().Id;
            await manufacturersRef.Document(id).SetAsync(manufacturer.ToDict());
            return id;
        }
        public async Task<string> AddDevice(Device device, Utils.DeviceType deviceType)
        {
            var id = errorsRef.Document().Id;
            switch (deviceType)
            {
                case Utils.DeviceType.Processor:
                    await processorsRef.Document(id).SetAsync((device as Processor).ToDict());
                    break;
                case Utils.DeviceType.GraphicCard:
                    await graphicCardsRef.Document(id).SetAsync((device as GraphicCard).ToDict());
                    break;
                case Utils.DeviceType.HardDrive:
                    await hardDrivesRef.Document(id).SetAsync((device as HardDrive).ToDict());
                    break;
                case Utils.DeviceType.Motherboard:
                    await motherboardsRef.Document(id).SetAsync((device as Motherboard).ToDict());
                    break;
                case Utils.DeviceType.DiskDrive:
                    await diskDrivesRef.Document(id).SetAsync((device as DiskDrive).ToDict());
                    break;
                case Utils.DeviceType.Memory:
                    await memoriesRef.Document(id).SetAsync((device as Memory).ToDict());
                    break;
                case Utils.DeviceType.PowerSupply:
                    await powerSuppliesRef.Document(id).SetAsync((device as PowerSupply).ToDict());
                    break;
                default:
                    break;
            }
            return id;
        }
        public async Task<List<Computer>> GetComputers()
        {
            var computers = new List<Computer>();
            var snapshot = await computersRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var computer = new Computer(dict)
                {
                    Id = document.Id
                };
                computers.Add(computer);
            }
            return computers;
        }
        public async Task<List<GraphicCard>> GetGraphicCards()
        {
            var graphicCards = new List<GraphicCard>();
            var snapshot = await graphicCardsRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var graphicCard = new GraphicCard(dict)
                {
                    Id = document.Id
                };
                graphicCards.Add(graphicCard);
            }
            return graphicCards;
        }
        public async Task<List<HardDrive>> GetHardDrives()
        {
            var hardDrives = new List<HardDrive>();
            var snapshot = await hardDrivesRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var hardDrive = new HardDrive(dict)
                {
                    Id = document.Id
                };
                hardDrives.Add(hardDrive);
            }
            return hardDrives;
        }
        public async Task<List<Memory>> GetMemories()
        {
            var memories = new List<Memory>();
            var snapshot = await memoriesRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var memory = new Memory(dict)
                {
                    Id = document.Id
                };
                memories.Add(memory);
            }
            return memories;
        }
        public async Task<List<PowerSupply>> GetPowerSupplies()
        {
            var powerSupplies = new List<PowerSupply>();
            var snapshot = await powerSuppliesRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var powerSupply = new PowerSupply(dict)
                {
                    Id = document.Id
                };
                powerSupplies.Add(powerSupply);
            }
            return powerSupplies;
        }
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = new List<Employee>();
            var snapshot = await employeesRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var employee = new Employee(dict)
                {
                    Id = document.Id
                };
                employees.Add(employee);
            }
            return employees;
        }
        public async Task<List<DiskDrive>> GetDiskDrives()
        {
            var diskDrives = new List<DiskDrive>();
            var snapshot = await diskDrivesRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var diskDrive = new DiskDrive(dict)
                {
                    Id = document.Id
                };
                diskDrives.Add(diskDrive);
            }
            return diskDrives;
        }
        public async Task<List<Processor>> GetProcessors()
        {
            var processors = new List<Processor>();
            var snapshot = await processorsRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var processor = new Processor(dict)
                {
                    Id = document.Id
                };
                processors.Add(processor);
            }
            return processors;
        }
        public async Task<List<Motherboard>> GetMotherboards()
        {
            var motherboards = new List<Motherboard>();
            var snapshot = await motherboardsRef.GetSnapshotAsync();
            foreach(var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var motherboard = new Motherboard(dict)
                {
                    Id = document.Id
                };
                motherboards.Add(motherboard);
            }
            return motherboards;
        }
        public async Task<List<Manufacturer>> GetManufacturers()
        {
            var manufacturers = new List<Manufacturer>();
            var snapshot = await manufacturersRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var manufacturer = new Manufacturer(dict)
                {
                    Id = document.Id
                };
                manufacturers.Add(manufacturer);
            }
            return manufacturers;
        }
        public async Task<List<Status>> GetStatuses()
        {
            var statuses = new List<Status>();
            var snapshot = await statusesRef.GetSnapshotAsync();
            foreach (var document in snapshot.Documents)
            {
                var dict = document.ToDictionary();
                var status = new Status(dict)
                {
                    Id = document.Id
                };
                statuses.Add(status);
            }
            return statuses;
        }
    }
}
