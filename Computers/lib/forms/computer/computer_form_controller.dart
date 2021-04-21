import 'package:computers/database.dart';
import 'package:computers/home_page/computers_page/computers_page.dart';
import 'package:computers/home_page/computers_page/computers_page_controller.dart';
import 'package:computers/models/computer.dart';
import 'package:computers/models/disk_drive.dart';
import 'package:computers/models/employee.dart';
import 'package:computers/models/manufacturer.dart';
import 'package:computers/models/motherboard.dart';
import 'package:computers/models/processor.dart';
import 'package:computers/models/status.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:uuid/uuid.dart';

class ComputerFormController extends GetxController {

  Computer computer = Computer();
  
  List<Manufacturer> manufacturers = [];
  List<Employee> employees = [];
  List<DiskDrive> diskDrives = [];
  List<Processor> processors = [];
  List<Motherboard> motherboards = [];
  List<Status> statuses = [];
  
  String model;
  String itemNo;
  String ip;
  Manufacturer manufacturer;
  Employee employee;
  DiskDrive diskDrive;
  Processor processor;
  Motherboard motherboard;
  Status status;

  bool editing = false;

  @override
  void onInit() {
    super.onInit();
    if (Get.arguments != null) {
      computer = Get.arguments as Computer;
      model = computer.model;
      itemNo = computer.itemNo;
      ip = computer.ip;
      manufacturer = computer.manufactuer;
      employee = computer.employee;
      diskDrive = computer.diskDrive;
      processor = computer.processor;
      motherboard = computer.motherboard;
      status = computer.status;
      editing = true;
    }
  }

  @override
  void onReady() {
    fetchData();
    super.onReady();
  }

  void submit() async {
    computer.model = model;
    computer.itemNo = itemNo;
    computer.ip = ip;
    computer.manufacturerId = manufacturer?.id;
    computer.employeeId = employee?.id;
    computer.diskDriveId = diskDrive?.id;
    computer.processorId = processor?.id;
    computer.motherboardId = motherboard?.id;
    computer.statusId = status?.id;
    if (!editing) {
      computer.id = Uuid().v4();
    }
    await Database.addComputer(computer);
    if (employee != null) {
      employee.computerId = computer.id;
      await Database.addEmployee(employee);
    }
    Get.find<ComputersPageController>().updateComputers();
    Get.back();
  }

  void fetchData() {
    manufacturers = Database.getManufacturers();
    employees = Database.getEmployees();
    diskDrives = Database.getDiskDrives();
    processors = Database.getProcessors();
    motherboards = Database.getMotherboards();
    statuses = Database.getStatuses();
    update();
  }

  void modelTextChanged(String model) {
    this.model = model;
  }

  void itemNoTextChanged(String itemNo) {
    this.itemNo = itemNo;
  }

  void ipTextChanged(String ip) {
    this.ip = ip;
  }


  void createEmployee() {
    Get.toNamed('/employee');
  }

  void createMotherboard() {
    
  }

  void createProcessor() {
    
  }

  void createDiskDrive() {
    
  }

  void createManufacturer() {
    Get.toNamed('/manufacturer');
  }

  void createStatus() {
    Get.toNamed('/status');
  }

  void selectManufacturer(Manufacturer manufacturer) {
    this.manufacturer = manufacturer;
    update();
  }

  void selectEmployee(Employee employee) {
    this.employee = employee;
    update();
  }

  void selectDiskDrive(DiskDrive diskDrive) {
    this.diskDrive = diskDrive;
    update();
  }

  void selectProcessor(Processor processor) {
    this.processor = processor;
    update();
  }

  void selectMotherboard(Motherboard motherboard) {
    this.motherboard = motherboard;
    update();
  }

  void selectStatus(Status status) {
    this.status = status;
    update();
  }

  void setNewEmployee(Employee employee) {
    this.employee = employee;
    employees.add(employee);
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

  void back() {
    Get.back();
  }
}