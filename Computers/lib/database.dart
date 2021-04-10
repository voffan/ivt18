import 'package:computers/models/computer.dart';
import 'package:computers/models/disk_drive.dart';
import 'package:computers/models/employee.dart';
import 'package:computers/models/graphic_card.dart';
import 'package:computers/models/hard_drive.dart';
import 'package:computers/models/manufacturer.dart';
import 'package:computers/models/memory.dart';
import 'package:computers/models/motherboard.dart';
import 'package:computers/models/power_supply.dart';
import 'package:computers/models/processor.dart';
import 'package:computers/models/status.dart';
import 'package:hive/hive.dart';
import 'package:hive_flutter/hive_flutter.dart';

class Database {

  static Box<Computer> computersBox;
  static Box<Employee> employeesBox;
  static Box<GraphicCard> graphicCardsBox;
  static Box<HardDrive> hardDrivesBox;
  static Box<Manufacturer> manufacturersBox;
  static Box<Memory> memoriesBox;
  static Box<Motherboard> motherboardsBox;
  static Box<PowerSupply> powerSuppliesBox;
  static Box<Processor> processorsBox;
  static Box<Status> statusesBox;
  static Box<DiskDrive> diskDrivesBox;

  static Future<void> init() async {
    await Hive.initFlutter();

    Hive.registerAdapter(ComputerAdapter());
    Hive.registerAdapter(EmployeeAdapter());
    Hive.registerAdapter(GraphicCardAdapter());
    Hive.registerAdapter(HardDriveAdapter());
    Hive.registerAdapter(ManufacturerAdapter());
    Hive.registerAdapter(MemoryAdapter());
    Hive.registerAdapter(MotherboardAdapter());
    Hive.registerAdapter(PowerSupplyAdapter());
    Hive.registerAdapter(ProcessorAdapter());
    Hive.registerAdapter(StatusAdapter());
    Hive.registerAdapter(DiskDriveAdapter());
    
    computersBox = await Hive.openBox<Computer>(Computer.boxName);
    employeesBox = await Hive.openBox<Employee>(Employee.boxName);
    graphicCardsBox = await Hive.openBox<GraphicCard>(GraphicCard.boxName);
    hardDrivesBox = await Hive.openBox<HardDrive>(HardDrive.boxName);
    manufacturersBox = await Hive.openBox<Manufacturer>(Manufacturer.boxName);
    memoriesBox = await Hive.openBox<Memory>(Memory.boxName);
    motherboardsBox = await Hive.openBox<Motherboard>(Motherboard.boxName);
    powerSuppliesBox = await Hive.openBox<PowerSupply>(PowerSupply.boxName);
    processorsBox = await Hive.openBox<Processor>(Processor.boxName);
    statusesBox = await Hive.openBox<Status>(Status.boxName);
    diskDrivesBox = await Hive.openBox<DiskDrive>(DiskDrive.boxName);
  }

  static List<Computer> getComputers() {
    return computersBox.values.toList();
  }

  static Future<void> addComputer(Computer computer) async {
    await computersBox.put(computer.id, computer);
  }

  static Future<void> deleteComputer(Computer computer) async {
    if (computer.employeeId != null) {
      final employee = employeesBox.get(computer.employeeId);
      if (employee != null) {
        employee.computerId = null;
        await employeesBox.put(employee.id, employee);
      }
      employeesBox.get(computer.employeeId)?.computerId = null;
    }
    if (computer.diskDriveId != null) {
      final diskDrive = diskDrivesBox.get(computer.diskDriveId);
      if (diskDrive != null) {
        diskDrive.computerId = null;
        await diskDrivesBox.put(diskDrive.id, diskDrive);
      }
      diskDrivesBox.get(computer.diskDriveId)?.computerId = null;
    }
    if (computer.processorId != null) {
      final processor = processorsBox.get(computer.processorId);
      if (processor != null) {
        processor.computerId = null;
        await processorsBox.put(processor.id, processor);
      }
      processorsBox.get(computer.processorId)?.computerId = null;
    }
    if (computer.motherboardId != null) {
      final motherboard = motherboardsBox.get(computer.motherboardId);
      if (motherboard != null) {
        motherboard.computerId = null;
        await motherboardsBox.put(motherboard.id, motherboard);
      }
    }
    await computersBox.delete(computer.id);
  }

  static Manufacturer getManufacturer(String id) {
    return manufacturersBox.get(id);
  }

  static Employee getEmployee(String id) {
    return employeesBox.get(id);
  }

  static Processor getProcessor(String id) {
    return processorsBox.get(id);
  }

  static Motherboard getMotherboard(String id) {
    return motherboardsBox.get(id);
  }

  static DiskDrive getDiskDrive(String id) {
    return diskDrivesBox.get(id);
  }
}