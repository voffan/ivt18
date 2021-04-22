import 'package:computers/database.dart';
import 'package:computers/models/disk_drive.dart';
import 'package:computers/models/graphic_card.dart';
import 'package:computers/models/hard_drive.dart';
import 'package:computers/models/manufacturer.dart';
import 'package:computers/models/memory.dart';
import 'package:computers/models/motherboard.dart';
import 'package:computers/models/power_supply.dart';
import 'package:computers/models/processor.dart';
import 'package:computers/models/status.dart';
import 'package:get/get.dart';
import 'package:uuid/uuid.dart';

enum DeviceType {
  processor,
  graphicCard,
  hardDrive,
  motherboard,
  memory,
  powerSupply,
  diskDrive,
  none
}

class DeviceFormController extends GetxController {
  
  DeviceType deviceType;
  dynamic device;

  List<Manufacturer> manufacturers = [];
  List<Status> statuses = [];

  String model;
  int price;
  Manufacturer manufacturer;
  Status status;

  bool editing = false;

  @override
  void onInit() {
    deviceType = (Get.arguments as DeviceType) ?? DeviceType.none;
    initDevice();
    super.onInit();
  }

  @override
  void onReady() {
    fetchData();
    super.onReady();
  }

  void fetchData() {
    manufacturers = Database.getManufacturers();
    statuses = Database.getStatuses();
    update();
  }

  Future<void> submit() async {
    device.model = model;
    device.price = price;
    device.statusId = status?.id;
    device.manufacturerId = manufacturer?.id;
    if (!editing) {
      device.id = Uuid().v4();
    }
    await addDevice();
    Get.back();
    // computer.model = model;
    // computer.itemNo = itemNo;
    // computer.ip = ip;
    // computer.manufacturerId = manufacturer?.id;
    // computer.employeeId = employee?.id;
    // computer.diskDriveId = diskDrive?.id;
    // computer.processorId = processor?.id;
    // computer.motherboardId = motherboard?.id;
    // computer.statusId = status?.id;
    // if (!editing) {
    //   computer.id = Uuid().v4();
    // }
    // await Database.addComputer(computer);
    // if (employee != null) {
    //   employee.computerId = computer.id;
    //   await Database.addEmployee(employee);
    // }
    // Get.find<ComputersPageController>().updateComputers();
    // Get.back();
  }

  void back() {
    Get.back();
  }

  Future<void> addDevice() async {
    switch (deviceType) {
      case DeviceType.processor:
        await Database.addProcessor(device);
        break;
      case DeviceType.graphicCard:
        await Database.addGraphicCard(device);
        break;
      case DeviceType.hardDrive:
        await Database.addHardDrive(device);
        break;
      case DeviceType.motherboard:
        await Database.addMotherboard(device);
        break;
      case DeviceType.memory:
        await Database.addMemory(device);
        break;
      case DeviceType.powerSupply:
        await Database.addPowerSupply(device);
        break;
      case DeviceType.diskDrive:
        await Database.addDiskDrive(device);
        break;
      case DeviceType.none:
        break;
    }
  }

  void nameTextChanged(String model) {
    this.model = model;
  }

  void priceTextChanged(String price) {
    final parsed = int.tryParse(price);
    if (parsed != null) {
      this.price = parsed;
    } else {
      // TODO: Текст в стоимости
    }
  }

  void selectManufacturer(Manufacturer manufacturer) {
    this.manufacturer = manufacturer;
    update();
  }

  void selectStatus(Status status) {
    this.status = status;
    update();
  }

  void setNewManufacturer(Manufacturer manufacturer) {
    this.manufacturer = manufacturer;
    manufacturers.add(manufacturer);
    update();
  }

  void setNewStatus(Status status) {
    this.status = status;
    statuses.add(status);
    update();
  }

  void createManufacturer() {
    Get.toNamed('/manufacturer');
  }

  void createStatus() {
    Get.toNamed('/status');
  }

  void initDevice() {
    switch (deviceType) {
      case DeviceType.diskDrive:
        device = DiskDrive();
        break;
      case DeviceType.graphicCard:
        device = GraphicCard();
        break;
      case DeviceType.hardDrive:
        device = HardDrive();
        break;
      case DeviceType.memory:
        device = Memory();
        break;
      case DeviceType.motherboard:
        device = Motherboard();
        break;
      case DeviceType.powerSupply:
        device = PowerSupply();
        break;
      case DeviceType.processor:
        device = Processor();
        break;
      default:
        break;
    }
  }
}