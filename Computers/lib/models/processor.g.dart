// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'processor.dart';

// **************************************************************************
// TypeAdapterGenerator
// **************************************************************************

class ProcessorAdapter extends TypeAdapter<Processor> {
  @override
  final int typeId = 6;

  @override
  Processor read(BinaryReader reader) {
    final numOfFields = reader.readByte();
    final fields = <int, dynamic>{
      for (int i = 0; i < numOfFields; i++) reader.readByte(): reader.read(),
    };
    return Processor()
      ..id = fields[0] as String
      ..model = fields[1] as String
      ..price = fields[2] as int
      ..manufacturerId = fields[3] as String
      ..statusId = fields[4] as String
      ..frequency = fields[5] as String
      ..cores = fields[6] as int
      ..threads = fields[7] as int
      ..computerId = fields[8] as String;
  }

  @override
  void write(BinaryWriter writer, Processor obj) {
    writer
      ..writeByte(9)
      ..writeByte(0)
      ..write(obj.id)
      ..writeByte(1)
      ..write(obj.model)
      ..writeByte(2)
      ..write(obj.price)
      ..writeByte(3)
      ..write(obj.manufacturerId)
      ..writeByte(4)
      ..write(obj.statusId)
      ..writeByte(5)
      ..write(obj.frequency)
      ..writeByte(6)
      ..write(obj.cores)
      ..writeByte(7)
      ..write(obj.threads)
      ..writeByte(8)
      ..write(obj.computerId);
  }

  @override
  int get hashCode => typeId.hashCode;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is ProcessorAdapter &&
          runtimeType == other.runtimeType &&
          typeId == other.typeId;
}
