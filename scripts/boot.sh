#!/usr/bin/env bash

echo "Boot starting..."

docker run -d -p 8080:80 --name CountYourself_Service countyourself_service

echo "Boot complete"