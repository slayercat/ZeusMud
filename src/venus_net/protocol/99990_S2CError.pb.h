// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 99990_S2CError.proto

#ifndef PROTOBUF_99990_5fS2CError_2eproto__INCLUDED
#define PROTOBUF_99990_5fS2CError_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 2005000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 2005000 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/unknown_field_set.h>
// @@protoc_insertion_point(includes)

namespace Protocol {

// Internal implementation detail -- do not call these.
void  protobuf_AddDesc_99990_5fS2CError_2eproto();
void protobuf_AssignDesc_99990_5fS2CError_2eproto();
void protobuf_ShutdownFile_99990_5fS2CError_2eproto();

class S2CError;

// ===================================================================

class S2CError : public ::google::protobuf::Message {
 public:
  S2CError();
  virtual ~S2CError();

  S2CError(const S2CError& from);

  inline S2CError& operator=(const S2CError& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const S2CError& default_instance();

  void Swap(S2CError* other);

  // implements Message ----------------------------------------------

  S2CError* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const S2CError& from);
  void MergeFrom(const S2CError& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // required uint32 error_code = 1;
  inline bool has_error_code() const;
  inline void clear_error_code();
  static const int kErrorCodeFieldNumber = 1;
  inline ::google::protobuf::uint32 error_code() const;
  inline void set_error_code(::google::protobuf::uint32 value);

  // @@protoc_insertion_point(class_scope:Protocol.S2CError)
 private:
  inline void set_has_error_code();
  inline void clear_has_error_code();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::uint32 error_code_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_99990_5fS2CError_2eproto();
  friend void protobuf_AssignDesc_99990_5fS2CError_2eproto();
  friend void protobuf_ShutdownFile_99990_5fS2CError_2eproto();

  void InitAsDefaultInstance();
  static S2CError* default_instance_;
};
// ===================================================================


// ===================================================================

// S2CError

// required uint32 error_code = 1;
inline bool S2CError::has_error_code() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void S2CError::set_has_error_code() {
  _has_bits_[0] |= 0x00000001u;
}
inline void S2CError::clear_has_error_code() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void S2CError::clear_error_code() {
  error_code_ = 0u;
  clear_has_error_code();
}
inline ::google::protobuf::uint32 S2CError::error_code() const {
  return error_code_;
}
inline void S2CError::set_error_code(::google::protobuf::uint32 value) {
  set_has_error_code();
  error_code_ = value;
}


// @@protoc_insertion_point(namespace_scope)

}  // namespace Protocol

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_99990_5fS2CError_2eproto__INCLUDED
