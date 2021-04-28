import 'package:computers/database.dart';
import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:computers/home_page/computers_page/computers_page_controller.dart';
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

  String frequency;
  String capacity;
  String power;

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
    writeUniqueFields();
    if (!editing) {
      device.id = Uuid().v4();
    }
    await saveDevice();
    Get.find<ComputerFormController>().fetchData();
    Get.back();
  }

  void back() {
    Get.back();
  }

  Future<void> saveDevice() async {
    switch (deviceType) {
      case DeviceType.processor: // Частота (frequency) Гц
        await Database.addProcessor(device);
        break;
      case DeviceType.graphicCard: // Объем памяти (capacity) Мб Гб
        await Database.addGraphicCard(device);
        break;
      case DeviceType.hardDrive: // Объем памяти (capacity) Мб Гб
        await Database.addHardDrive(device);
        break;
      case DeviceType.motherboard: // Ничего нет
        await Database.addMotherboard(device);
        break;
      case DeviceType.memory: // Объем памяти (capacity) Мб Гб
        await Database.addMemory(device);
        break;
      case DeviceType.powerSupply: // Мощность (power) Вт
        await Database.addPowerSupply(device);
        break;
      case DeviceType.diskDrive: // Ничего нет
        await Database.addDiskDrive(device);
        break;
      case DeviceType.none:
        break;
    }
  }

  void writeUniqueFields() {
    switch (deviceType) {
      case DeviceType.processor:
        device.frequency = frequency;
        break;
      case DeviceType.graphicCard:
        device.capacity = capacity;
        break;
      case DeviceType.hardDrive:
        device.capacity = capacity;
        break;
      case DeviceType.motherboard:
        break;
      case DeviceType.memory:
        device.capacity = capacity;
        break;
      case DeviceType.powerSupply:
        device.power = power;
        break;
      case DeviceType.diskDrive:
        break;
      case DeviceType.none:
        break;
    }
  }

  void readUniqueFields(dynamic device) {
    switch (deviceType) {
      case DeviceType.processor:
        frequency = device.frequency;
        break;
      case DeviceType.graphicCard:
        capacity = device.capacity;
        break;
      case DeviceType.hardDrive:
        capacity = device.capacity;
        break;
      case DeviceType.motherboard:
        break;
      case DeviceType.memory:
        capacity = device.capacity;
        break;
      case DeviceType.powerSupply:
        power = device.power;
        break;
      case DeviceType.diskDrive:
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

  void capacityTextChanged(String capacity) {
    this.capacity = capacity;
  }

  void frequencyTextChanged(String frequency) {
    this.frequency = frequency;
  }

  void powerTextChanged(String power) {
    this.power = power;
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