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

  String name;
  int price;
  Manufacturer manufacturer;
  Status status;

  bool editing = false;

  @override
  void onInit() {
    deviceType = (Get.arguments[0] as DeviceType) ?? DeviceType.none;
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

  }

  void back() {
    Get.back();
  }

  void nameTextChanged(String name) {
    this.name = name;
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