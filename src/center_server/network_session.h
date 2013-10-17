#ifndef __SESSION_H__
#define __SESSION_H__

#include <common.h>
#include <network_common.h>
#include <protobuf.h>
#include <packet.h>
#include <tcp_connection.h>
#include "opcodes.h"
#include "game_database_session.h"
#include "game_util.h"

class NetworkSession
{
public:
    NetworkSession(const uint64& session_id);
    virtual ~NetworkSession();

public:
    void set_connection_ptr(const TcpConnectionPtr& connection);
    uint64 session_id() const;

    template <typename T> void send_message(uint32 opcode, const T& message)
    {
        if (_connection != nullptr)
        {
            size_t messageSize = message.ByteSize();
            size_t packetSize = ServerPacket::HEADER_LENGTH + messageSize;

            ByteBuffer packet_buffer;
            packet_buffer << packetSize;
            packet_buffer << opcode;
            
            byte* message_data = new byte[messageSize];
            message.SerializeToArray(message_data, messageSize);
            packet_buffer.append(message_data, messageSize);

            _connection->writeAsync(packet_buffer.buffer(), packet_buffer.size());

            SAFE_DELETE_ARR(message_data);
        }
    }

public:
    void user_login_handler(const NetworkMessage& message);
    void user_register_handler(const NetworkMessage& message);

private:
    uint64 _sessionId;
    TcpConnectionPtr _connection;
};

#endif