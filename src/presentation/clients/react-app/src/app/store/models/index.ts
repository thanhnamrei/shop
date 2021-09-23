import { Models } from '@rematch/core';
import { count } from './count';

export interface RootModel extends Models<RootModel> {}

export const models: RootModel = { count };
