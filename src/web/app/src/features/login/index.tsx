import { Box, Column, Row } from '@/components/box';
import Button from '@/components/button/Button';
import { Form } from '@/components/form/form';
import { Input } from '@/components/form/input/Input';
import { Label } from '@/components/label';
import { Text } from '@/components/text';

const View = () => {
  return (
    <Box>
      <Text weight="semibold" size={40}>
        Đăng Nhập
      </Text>
      <Text>
        Đăng nhập bằng địa chỉ email và mật khẩu của bạn
      </Text>
      <Form action="">
        <Column>
          <Label required>Nhập email</Label>
          <Input />
        </Column>
        <Column>
          <Label required>Nhập mật khẩu</Label>
          <Input type="password" />
        </Column>
        <Button>Đăng nhập</Button>
      </Form>
    </Box>
  );
};
export default View;
