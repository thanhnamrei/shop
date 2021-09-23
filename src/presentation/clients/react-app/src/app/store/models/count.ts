import { createModel, Models } from '@rematch/core';
import { RootModel } from '.';

type CountState = {
  count: number;
};

export const count = createModel<RootModel>()({
  state: {
    count: 0,
  } as CountState,
  reducers: {},
  effects: {},
});
