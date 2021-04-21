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
import 'package:flutter/material.dart';
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
  static Box statesBox;

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
    statesBox = await Hive.openBox('states');
  }

  // MARK: Компьютеры
  static List<Computer> getComputers() => computersBox.values.toList();

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

  // MARK: Производители
  static Manufacturer getManufacturer(String id) => manufacturersBox.get(id);
  
  static List<Manufacturer> getManufacturers() => manufacturersBox.values.toList();

  static Future<void> addManufacturer(Manufacturer manufacturer) async {
    await manufacturersBox.put(manufacturer.id, manufacturer);
  }


  // MARK: Сотрудники
  static Employee getEmployee(String id) => employeesBox.get(id);
  
  static List<Employee> getEmployees() => employeesBox.values.toList();

  static Future<void> addEmployee(Employee employee) async {
    await employeesBox.put(employee.id, employee);
  }


  // MARK: Процессоры
  static Processor getProcessor(String id) => processorsBox.get(id);
  
  static List<Processor> getProcessors() => processorsBox.values.toList();

  static Future<void> addProcessor(Processor processor) async {
    await processorsBox.put(processor.id, processor);
  }


  // MARK: Материнские платы
  static Motherboard getMotherboard(String id) => motherboardsBox.get(id);
  
  static List<Motherboard> getMotherboards() => motherboardsBox.values.toList();

  static Future<void> addMotherboard(Motherboard motherboard) async {
    await motherboardsBox.put(motherboard.id, motherboard);
  }
  

  // MARK: Дисководы
  static DiskDrive getDiskDrive(String id) => diskDrivesBox.get(id);
  
  static List<DiskDrive> getDiskDrives() => diskDrivesBox.values.toList();

  static Future<void> addDiskDrive(DiskDrive diskDrive) async {
    await diskDrivesBox.put(diskDrive.id, diskDrive);
  }


  // MARK: Статусы
  static Status getStatus(String id) => statusesBox.get(id);

  static List<Status> getStatuses() => statusesBox.values.toList();

  static Future<void> addStatus(Status status) async {
    await statusesBox.put(status.id, status);
  }


  // MARK: Тема
  static ThemeMode getThemeMode() {
    final isDarkMode = statesBox.get('darkMode') as bool;
    if (isDarkMode == null) {
      return ThemeMode.light;
    } else {
      return isDarkMode ? ThemeMode.dark : ThemeMode.light;
    }
  }

  static Future<void> setThemeMode(ThemeMode themeMode) async {
    final isDarkMode = themeMode == ThemeMode.dark;
    await statesBox.put('darkMode', isDarkMode);
  }
}