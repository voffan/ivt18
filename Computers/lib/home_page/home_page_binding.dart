import 'package:computers/home_page/computers_page/computers_page_controller.dart';
import 'package:computers/home_page/home_page_controller.dart';
import 'package:get/get.dart';

class HomePageBinding extends Bindings {
  @override
  void dependencies() {
    Get.put(HomePageController());
    Get.put(ComputersPageController());
  }
}