import axios, { AxiosRequestConfig } from 'axios';

const config: AxiosRequestConfig = {
  baseURL: 'https://localhost:44354/',
  headers: {},
};

const instance = axios.create(config);

export const get = async <T>(url: string, params?: Record<string, unknown>) =>
  (await instance.get<T>(url, { params })).data;

export const post = async (
  url: string,
  body: Record<string, unknown>,
  params?: Record<string, unknown>
) => await instance.post<void>(url, JSON.stringify(body), { params });
