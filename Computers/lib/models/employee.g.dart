// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'employee.dart';

// **************************************************************************
// TypeAdapterGenerator
// **************************************************************************

class EmployeeAdapter extends TypeAdapter<Employee> {
  @override
  final int typeId = 9;

  @override
  Employee read(BinaryReader reader) {
    final numOfFields = reader.readByte();
    final fields = <int, dynamic>{
      for (int i = 0; i < numOfFields; i++) reader.readByte(): reader.read(),
    };
    return Employee()
      ..id = fields[0] as String
      ..surname = fields[1] as String
      ..name = fields[2] as String
      ..patronymicName = fields[3] as String
      ..room = fields[4] as String
      ..computerId = fields[5] as String;
  }

  @override
  void write(BinaryWriter writer, Employee obj) {
    writer
      ..writeByte(6)
      ..writeByte(0)
      ..write(obj.id)
      ..writeByte(1)
      ..write(obj.surname)
      ..writeByte(2)
      ..write(obj.name)
      ..writeByte(3)
      ..write(obj.patronymicName)
      ..writeByte(4)
      ..write(obj.room)
      ..writeByte(5)
      ..write(obj.computerId);
  }

  @override
  int get hashCode => typeId.hashCode;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is EmployeeAdapter &&
          runtimeType == other.runtimeType &&
          typeId == other.typeId;
}
